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
        StringBuilder output = new StringBuilder();
        while(stack.Any())
            output.Insert(0,stack.Pop());

        return output.ToString();
    }
}