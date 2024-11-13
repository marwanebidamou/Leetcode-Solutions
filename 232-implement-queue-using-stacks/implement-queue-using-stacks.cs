public class MyQueue {

    Stack<int> stack1;
    Stack<int> stack2;


    public MyQueue() {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    
    public void Push(int x) {
        if (stack1.Count==0)
        {
            stack1.Push(x);
            return;
        }

        stack2 = new Stack<int>();
        stack2.Push(x);

        int count=stack1.Count;
        List<int> temp = new List<int>();
        while(count > 0){
            int number = stack1.Peek();
            temp.Add(stack1.Pop());
            count--;
        }
        temp.Reverse();
        foreach(var n in temp){
            stack2.Push(n);
        }
        stack1 = stack2;
    }
    
    public int Pop() {
        return stack1.Pop();
    }
    
    public int Peek() {
        return stack1.Peek();
    }
    
    public bool Empty() {
        return stack1.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */