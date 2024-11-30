public class Solution {
    public int[] GetAverages(int[] nums, int k) {
        
        
        int[] avgs = new int[nums.Length];
        long[] prefixSum = new long[nums.Length];
        
        prefixSum[0] = nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            prefixSum[i] = prefixSum[i-1] + nums[i];
        }
        
        for(int i=0;i<prefixSum.Length;i++)
        {
            if(i<k || i+k>=prefixSum.Length)
            {
                avgs[i] = -1;
            }
            else
            {
                long left = i-k == 0 ? 0 :  prefixSum[i-k-1];
                long right = prefixSum[i+k];
                avgs[i] = (int)((right - left) / (2 * k + 1));
            }
        }
        
        return avgs;
        
    } 
}