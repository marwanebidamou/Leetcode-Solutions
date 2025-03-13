public class Solution {
    public int MaximumCount(int[] nums) {

        int positiveCount = 0;
        int negativeCount = 0;

        for(int i=0;i<nums.Length;i++)
        {
            positiveCount += nums[i]>0?1:0;
            negativeCount += nums[i]<0?1:0;
        }

        return Math.Max(positiveCount, negativeCount);
    }
}