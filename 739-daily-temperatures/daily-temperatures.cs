public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // Array to store the result
        int[] answer = new int[temperatures.Length];
        
        // Monotonic stack to track indices of temperatures
        Stack<int> stack = new Stack<int>();

        // Traverse the array from the end to the beginning
        for (int i = temperatures.Length - 1; i >= 0; i--) {
            // Remove indices with temperatures less than or equal to the current temperature
            while (stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i]) {
                stack.Pop();
            }

            // If stack is empty, no warmer day exists; otherwise, calculate the difference
            answer[i] = stack.Count == 0 ? 0 : stack.Peek() - i;

            // Add current index to the stack
            stack.Push(i);
        }

        return answer;
    }
}
