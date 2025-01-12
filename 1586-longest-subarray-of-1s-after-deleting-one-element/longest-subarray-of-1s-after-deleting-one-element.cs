public class Solution {
    public int LongestSubarray(int[] nums) {
        int lastestZeroIndex = -1; // Tracks the most recent 0 index
        int prevZeroIndex = -1;    // Tracks the second most recent 0 index
        int longestSubArray = 0;   // Stores the maximum length of the subarray of 1s

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                // Update the indices of the most recent and second most recent 0s
                prevZeroIndex = lastestZeroIndex;
                lastestZeroIndex = i;
            }
            // Calculate the current subarray length of 1s, skipping at most one 0
            int currentLength;
            if (lastestZeroIndex == -1 ) {
                currentLength = i + 1; // No second 0 encountered yet
            } else {
                currentLength = i - prevZeroIndex - 1; // Skip the earlier 0
            }
            longestSubArray = Math.Max(longestSubArray, currentLength);
        }

        // Edge case: If there is no 0 in the array, return nums.Length - 1
        if (lastestZeroIndex == -1) {
            return nums.Length - 1;
        }

        return longestSubArray;
    }
}
