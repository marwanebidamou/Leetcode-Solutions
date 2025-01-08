public class Solution {
    public string RemoveDuplicates(string s, int k) {
        // Stack to store characters
        Stack<char> stack = new Stack<char>();
        // Stack to store the count of consecutive characters
        Stack<int> stackCount = new Stack<int>();

        // Push the first character to initialize the stack
        stack.Push(s[0]);
        stackCount.Push(1);

        // Iterate through the string starting from the second character
        for (int i = 1; i < s.Length; i++) {
            // Check if the stack is not empty and the current character matches the top of the stack
            if (stack.Any() && stack.Peek() == s[i]) {
                // If the count of the top character reaches k-1, remove it
                if (stackCount.Any() && stackCount.Peek() == k - 1) {
                    // Remove all occurrences of the character from the stack
                    while (stack.Any() && stack.Peek() == s[i]) {
                        stack.Pop();
                    }
                    // Remove the corresponding count from the stackCount
                    stackCount.Pop();
                } else {
                    // Increment the count of the current character and push it back
                    stack.Push(s[i]);
                    stackCount.Push(stackCount.Pop() + 1);
                }
            } else {
                // If the character doesn't match the top, add it to the stack
                stack.Push(s[i]);
                stackCount.Push(1);
            }
        }

        // Reconstruct the result string by reversing the stack
        return new string(stack.Reverse().ToArray());
    }
}