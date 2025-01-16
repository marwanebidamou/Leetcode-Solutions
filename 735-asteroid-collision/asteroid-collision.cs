public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();

        foreach (var asteroid in asteroids) {
            bool isDestroyed = false;

            while (stack.Any() && asteroid < 0 && stack.Peek() > 0) {
                if (Math.Abs(asteroid) > Math.Abs(stack.Peek())) {
                    stack.Pop(); 
                } else if (Math.Abs(asteroid) == Math.Abs(stack.Peek())) {
                    stack.Pop(); 
                    isDestroyed = true;
                    break;
                } else {
                    isDestroyed = true;
                    break;
                }
            }

            if (!isDestroyed) {
                stack.Push(asteroid);
            }
        }

        return stack.Reverse().ToArray();
    }
}
