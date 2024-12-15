public class Solution {
    public int MaximumSum(int[] nums) {
        Dictionary<int, int[]> map = new Dictionary<int, int[]>(); // Map to store two largest numbers for each digit sum
        int maximumSum = -1; // Track maximum sum of two numbers with the same digit sum

        for (int i = 0; i < nums.Length; i++) {
            int currentNumberDigitsSum = 0, currentNumber = nums[i];

            // Calculate digit sum of the current number
            while (currentNumber > 0) {
                currentNumberDigitsSum += currentNumber % 10;
                currentNumber /= 10;
            }

            // If digit sum is not in the map, initialize it
            if (!map.ContainsKey(currentNumberDigitsSum)) {
                map.Add(currentNumberDigitsSum, new int[2] { nums[i], 0 });
            } else {
                // Update the two largest numbers for this digit sum
                int[] vals = map[currentNumberDigitsSum];
                if (vals[1] == 0) vals[1] = nums[i]; // Second largest is empty
                else if (vals[0] < nums[i] && vals[1] < nums[i]) { 
                    vals[0] = Math.Max(vals[0], vals[1]); 
                    vals[1] = nums[i]; 
                } else if (vals[0] < nums[i]) vals[0] = nums[i]; // Update largest
                else if (vals[1] < nums[i]) vals[1] = nums[i]; // Update second largest

                // Calculate maximum sum if both numbers exist
                maximumSum = Math.Max(maximumSum, vals[0] + vals[1]);
            }
        }

        return maximumSum; // Return the result
    }
}