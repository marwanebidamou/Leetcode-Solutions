public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        
        Stack<int> stackSandwiches = new Stack<int>();
        Queue<int> qStudents = new Queue<int>();

        for(int i=0;i<sandwiches.Length;i++){
            stackSandwiches.Push(sandwiches[sandwiches.Length-1-i]);
            qStudents.Enqueue(students[i]);
        }
        
        int eatCount=0;

        int skipCount=0;
        while(stackSandwiches.Count()>0){
            
            if (stackSandwiches.Peek() == qStudents.Peek())
            {
                skipCount=0;
                stackSandwiches.Pop();
                qStudents.Dequeue();
                eatCount++;
            }
            else
            {
                skipCount++;
                qStudents.Enqueue(qStudents.Dequeue());                
            }

            if (qStudents.Count()==skipCount)
                break;
        }


        return students.Length - eatCount;
    }
}