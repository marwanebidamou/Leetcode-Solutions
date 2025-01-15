public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums.Length <= 1 || k == 0)
            return;

        k = k % nums.Length; // Handle cases where k >= nums.Length

        int[] result = new int[nums.Length];

        int index = 0;

        for (int i = nums.Length - k; i < nums.Length; i++)
            result[index++] = nums[i];

        for (int i = 0; i < nums.Length - k; i++)
            result[index++] = nums[i];

        for (int i = 0; i < nums.Length; i++)
            nums[i] = result[i];
    }
}
