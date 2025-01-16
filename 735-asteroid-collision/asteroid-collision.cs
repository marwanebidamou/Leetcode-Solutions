public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        // Stack to keep track of surviving asteroids
        Stack<int> stack = new Stack<int>();

        foreach (var asteroid in asteroids) {
            bool isDestroyed = false; // Flag to check if the current asteroid is destroyed

            // Check for collisions: stack has a positive asteroid and the current one is negative
            while (stack.Any() && asteroid < 0 && stack.Peek() > 0) {
                // Compare absolute values of the colliding asteroids
                if (Math.Abs(asteroid) > Math.Abs(stack.Peek())) {
                    // Current asteroid destroys the top of the stack
                    stack.Pop();
                } else if (Math.Abs(asteroid) == Math.Abs(stack.Peek())) {
                    // Both asteroids are destroyed
                    stack.Pop();
                    isDestroyed = true; // Mark the current asteroid as destroyed
                    break;
                } else {
                    // Top of the stack survives, current asteroid is destroyed
                    isDestroyed = true;
                    break;
                }
            }

            // If the current asteroid is not destroyed, push it onto the stack
            if (!isDestroyed) {
                stack.Push(asteroid);
            }
        }

        // Return the remaining asteroids in the correct order
        return stack.Reverse().ToArray();
    }
}
