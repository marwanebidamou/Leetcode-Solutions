public class Solution {
    public int PartitionArray(int[] nums, int k) {
        Array.Sort(nums); // Step 1: Sort the array
        
        int partitionMin = nums[0]; // First element of the partition
        int count = 1; // At least one partition needed

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] - partitionMin > k) {
                count++; // Start a new partition
                partitionMin = nums[i]; // Reset the minimum element of the new partition
            }
        }

        return count;
    }
}
