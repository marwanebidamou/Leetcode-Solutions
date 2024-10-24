public class Solution {
    public int MissingNumber(int[] nums) {
        
        //total sum from 1 to n = n(n+1)/2
        int totalSum = nums.Length * (nums.Length+1) / 2;
        //calculate sum if nums
        int arraySum = 0;
        for(int i=0;i<nums.Length;i++)
        {
            arraySum += nums[i];
        }

        //calc missing int totalSum−arraySum
        return totalSum-arraySum;
    }
}