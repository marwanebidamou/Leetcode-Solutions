public class Solution {
    public bool BackspaceCompare(string s, string t) {

        Stack<char> stack1 = new Stack<char>();
        Stack<char> stack2 = new Stack<char>();

        for(int i=0; i<s.Length; i++)
        {
            if(s[i]!='#')
                stack1.Push(s[i]);
            else if(stack1.Count > 0)
                stack1.Pop();
        }

        for(int i=0; i<t.Length; i++)
        {
            if(t[i]!='#')
                stack2.Push(t[i]);
            else if(stack2.Count > 0)
                stack2.Pop();
        }

        if(stack1.Count != stack2.Count)
            return false;

        int count = stack1.Count;
        for(int i=0;i<count;i++)
        {
            if(stack1.Pop()!=stack2.Pop())
                return false;            
        }
        return true;
    }
}