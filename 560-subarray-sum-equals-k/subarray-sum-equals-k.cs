public class Solution {
    public int SubarraySum(int[] nums, int k) {

        int total=0;
        for(int left=0, right=0;left<nums.Length;left++)
        {
            int sum=0;

            for(int j=left;j<nums.Length;j++){
                sum+=nums[j];
                if(sum==k)
                    total++;
            }
        }

        return total;
    }
}