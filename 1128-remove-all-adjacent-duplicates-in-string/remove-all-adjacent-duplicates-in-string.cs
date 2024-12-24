public class Solution {
    public string RemoveDuplicates(string s) {
        
        char[] array = s.ToCharArray();

        Stack<char> stack = new Stack<char>();

        foreach(char letter in array)
        {
            if(stack.Count>0 && stack.Peek() == letter)
                stack.Pop();
            else
                stack.Push(letter);            
        }

        char[] output = new char[stack.Count];
        int index = stack.Count-1;
        while (stack.Count > 0)
        {
            output[index--] = stack.Pop();
        }
        
        return new string(output);
    }
}