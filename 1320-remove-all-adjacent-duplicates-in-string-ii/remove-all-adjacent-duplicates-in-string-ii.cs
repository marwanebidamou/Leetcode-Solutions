public class Solution {
    public string RemoveDuplicates(string s, int k) {
        Stack<char> stack = new Stack<char>();
        Stack<int> stackCount = new Stack<int>();

        stack.Push(s[0]);
        stackCount.Push(1);

        for(int i=1;i<s.Length;i++)
        {   
            if(stack.Any() && stack.Peek() == s[i])
            {
                if(stackCount.Any() && stackCount.Peek() == k-1)
                {
                    while(stack.Any() && stack.Peek()==s[i])
                    {
                        stack.Pop();
                    }
                    stackCount.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                    stackCount.Push(stackCount.Pop()+1);
                }                
            }
            else
            {
                stack.Push(s[i]);
                stackCount.Push(1);
            }
        }

        return new string(stack.Reverse().ToArray());
    }
}