class Solution {

    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }

        int i = 1; // Pointer for current index in the array
        int count = 1; // Count of the current element occurrences

        for (int j = 1; j < nums.Length; j++) {
            if (nums[j] == nums[j - 1]) {
                count++; // Increment count for the current element
            } else {
                count = 1; // Reset count for new element
            }

            if (count <= 2) {
                nums[i++] = nums[j]; // Update the array in place
            }
        }

        return i; // Return the new array length
    }
}