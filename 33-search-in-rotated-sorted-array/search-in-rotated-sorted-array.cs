public class Solution {
    public int Search(int[] nums, int target) {
        return SearchHelper(nums, target, 0, nums.Length - 1);
    }

    private int SearchHelper(int[] nums, int target, int left, int right) {
        // Base case: If the range is invalid, the target is not in the array
        if (left > right)
            return -1;

        // Calculate the middle index to divide the array
        int middleIndex = left + (right - left) / 2;

        // If the middle element matches the target, return its index
        if (nums[middleIndex] == target)
            return middleIndex;

        // Determine if the left part of the array is sorted
        if (nums[left] <= nums[middleIndex]) {
            // Check if the target lies within the sorted left part
            if (target >= nums[left] && target < nums[middleIndex]) {
                // Recur into the left part of the array
                return SearchHelper(nums, target, left, middleIndex - 1);
            } else {
                // Recur into the right part of the array
                return SearchHelper(nums, target, middleIndex + 1, right);
            }
        } else {
            // If the left part is not sorted, the right part must be sorted
            if (target > nums[middleIndex] && target <= nums[right]) {
                // Check if the target lies within the sorted right part
                return SearchHelper(nums, target, middleIndex + 1, right);
            } else {
                // Recur into the left part of the array
                return SearchHelper(nums, target, left, middleIndex - 1);
            }
        }
    }
}
