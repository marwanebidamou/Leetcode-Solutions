public class Solution {
    public int EvalRPN(string[] tokens) {
        // Use a stack to evaluate the Reverse Polish Notation.
        Stack<int> stack = new Stack<int>();

        foreach (var token in tokens) {
            // If the token is an operator, perform the corresponding operation.
            if (token == "+" || token == "-" || token == "*" || token == "/") {
                // Pop the last two elements from the stack for the operation.
                int number2 = stack.Pop();
                int number1 = stack.Pop();

                // Perform the operation and push the result back onto the stack.
                stack.Push(token switch {
                    "+" => number1 + number2,
                    "-" => number1 - number2,
                    "*" => number1 * number2,
                    "/" => number1 / number2
                });
            } else {
                // Parse the token as an integer and push it onto the stack.
                stack.Push(int.Parse(token));
            }
        }

        // Return the single result remaining in the stack.
        return stack.Pop();
    }
}
