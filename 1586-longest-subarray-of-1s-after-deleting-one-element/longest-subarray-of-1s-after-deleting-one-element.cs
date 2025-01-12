public class Solution {
    public int LongestSubarray(int[] nums) {
        
        int lastestZeroIndex = -1;
        int prevZeroIndex = -1;

        int longestSubArray = 0;

        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
            {
                if(lastestZeroIndex == -1)
                    lastestZeroIndex = i;
                else
                {
                    prevZeroIndex = lastestZeroIndex;
                    lastestZeroIndex = i;
                }             
            }
            else
            {
                if(prevZeroIndex == -1 && lastestZeroIndex==-1)
                    longestSubArray = Math.Max(longestSubArray, i+1);
                else
                    longestSubArray = Math.Max(longestSubArray, i-prevZeroIndex-1);
            }

        }

        if(lastestZeroIndex==-1)
            return nums.Length-1;

        return longestSubArray;
    }
}