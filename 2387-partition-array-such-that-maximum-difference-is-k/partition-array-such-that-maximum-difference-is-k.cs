public class Solution {
    public int PartitionArray(int[] nums, int k) {
        Array.Sort(nums);

        int x=nums[0];
        int count = 1;

        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i]-x > k)
            {
                count++;
                x = nums[i];
            }
        }

        return count;
    }
}