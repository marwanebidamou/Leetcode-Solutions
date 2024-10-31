public class Solution {
    public int Rob(int[] nums) {
        //if we have only one house => rob it
        if (nums.Length==1)
            return nums[0];

        //if we have only two houses => rob the one's with the max value
        if (nums.Length==2)
            return Math.Max(nums[0], nums[1]);

        //let's try to solve this problem using dynamic programming
        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0],nums[1]);

        //so each time we have two option, either take the last item, or the item at index i-2 + current item, so we peek the max, because it's the optimal solution
        for(int i=2;i<nums.Length;i++){
            dp[i] = Math.Max(dp[i-1], dp[i-2]+nums[i]);
        }

        return dp[nums.Length-1];
    }
}