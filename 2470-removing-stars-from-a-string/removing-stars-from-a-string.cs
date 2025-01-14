public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char character in s)
        {
            if(character == '*' && stack.Any())
                stack.Pop();
            else
                stack.Push(character);
        }

        return new string(stack.Reverse().ToArray());
    }
}