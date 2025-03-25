public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        Array.Sort(intervals, (a,b)=> a[0]-b[0]);
        
        Stack<int[]> stack = new Stack<int[]>();

        foreach(var item in intervals)
        {
            if(!stack.Any() || stack.Peek()[1] < item[0])
            {
                stack.Push(item);
            }
            else if(stack.Peek()[0] > item[0] || stack.Peek()[1] < item[1])
            {
                var pop = stack.Pop();
                stack.Push(new int[]{pop[0], item[1]});
            }
            else
            {
                // Do nothing
            }
        }

        return stack.ToArray();
    }
    
}