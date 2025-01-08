public class Solution {
    public string RemoveDuplicates(string s, int k) {
        Stack<char> stack = new Stack<char>();       // Stack to store characters
        Stack<int> stackCount = new Stack<int>();    // Stack to store counts of consecutive characters

        foreach (char c in s) {
            if (stack.Any() && stack.Peek() == c) {
                // Increment the count of the top character
                int count = stackCount.Pop() + 1;
                stackCount.Push(count);

                // If count reaches k, remove the characters
                if (count == k) {
                    stack.Pop();
                    stackCount.Pop();
                }
            } else {
                // Push new character with count 1
                stack.Push(c);
                stackCount.Push(1);
            }
        }

        // Reconstruct the string using the stacks
        var result = new StringBuilder();
        while (stack.Any()) {
            char c = stack.Pop();
            int count = stackCount.Pop();

            result.Insert(0, new string(c, count)); // Repeat the character `count` times
        }

        return result.ToString();
    }
}
