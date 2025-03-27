public class Solution {
    public int Rob(int[] nums) {

        var case1 =  helper(nums,0,nums.Length-2);
        var case2 =  helper(nums,1,nums.Length-1);

        return Math.Max(case1, case2);
    }

    public int helper(int[] nums, int start, int end)
    {
        if(nums.Length == 1){
            return nums[0];
        }
        else if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }

        int[] dp = new int[end-start+1];

        int dpIndex = 0;
        dp[dpIndex++] = nums[start];
        dp[dpIndex++] = Math.Max(nums[start], nums[start+1]);
        int numIndex = start+2;
        for(int i=start+2; i<=end;i++)
        {
            var index = dpIndex++;

            dp[index] = Math.Max(dp[index-1], dp[index-2]+nums[numIndex++]);
        }

        return dp[end-start];
    }
}