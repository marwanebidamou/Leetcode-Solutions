public class Solution {
    // Main method to solve the "House Robber II" problem (circular version)
    public int Rob(int[] nums) {
        // If there is only one house, return its value
        if (nums.Length == 1) return nums[0];

        // Case 1: Consider robbing from house 0 to second-last house (excluding the last)
        var case1 = helper(nums, 0, nums.Length - 2);
        
        // Case 2: Consider robbing from house 1 to the last house (excluding the first)
        var case2 = helper(nums, 1, nums.Length - 1);

        // Return the maximum of both cases (since you cannot rob both the first and last house)
        return Math.Max(case1, case2);
    }

    // Helper method to solve the linear "House Robber" problem between two indices
    public int helper(int[] nums, int start, int end) {
        // Handle base case: if there's only one house in the entire array
        if (nums.Length == 1) {
            return nums[0];
        }
        // Handle base case: if there are only two houses, return the max value
        else if (nums.Length == 2) {
            return Math.Max(nums[0], nums[1]);
        }

        // Initialize dynamic programming variables:
        // dp1: max amount robbed up to house i-2
        // dp2: max amount robbed up to house i-1
        int dp1 = nums[start];
        int dp2 = Math.Max(nums[start], nums[start + 1]);
        
        // Start checking from the third house in the subarray
        int numIndex = start + 2;

        // Loop through houses from `start + 2` to `end`
        for (int i = start + 2; i <= end; i++) {
            int tmp = dp1; // Save previous dp1
            dp1 = dp2; // Update dp1 to dp2 (shift window)
            // Update dp2 with the max of:
            // - previous dp2 (skip current house)
            // - tmp + current house value (rob current house)
            dp2 = Math.Max(dp2, tmp + nums[numIndex++]);
        }

        // Return the maximum amount that can be robbed in this subarray
        return dp2;
    }
}