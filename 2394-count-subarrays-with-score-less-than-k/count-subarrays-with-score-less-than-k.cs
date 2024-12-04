public class Solution {
    public long CountSubarrays(int[] nums, long k) {
        
        long currentSum = 0;
        long subArraysCount = 0;

        for(int left=0, right=0; right<nums.Length; right++)
        {
            currentSum += nums[right];

            while(currentSum * (right - left + 1) >= k)
            {
                currentSum -= nums[left];
                left++;
            }

            if(currentSum * (right - left + 1) < k)
            {
                subArraysCount += (right - left + 1);
            }
        }

        return subArraysCount;
    }
}