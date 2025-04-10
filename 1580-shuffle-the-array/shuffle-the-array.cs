public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int leftIndex = 0;
        int rightIndex = n;

        int[] result = new int[nums.Length];
        int insertIndex = 0;
        
        int index = 0;
        while(index<n)
        {
            result[insertIndex++] = nums[leftIndex++];
            result[insertIndex++] = nums[rightIndex++];
            index++;
        }

        return result;
    }
}