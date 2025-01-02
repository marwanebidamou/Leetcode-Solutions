public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 2) return nums.Length; // No need to process arrays with 2 or fewer elements
        
        int pointer = 2; // Pointer for the position to write in the modified array
        
        for (int index = 2; index < nums.Length; index++) {
            // If the current number is different from the number two places before,
            // it means we can keep this number.
            if (nums[index] != nums[pointer - 2]) {
                nums[pointer++] = nums[index];
            }
        }
        
        return pointer; // The length of the modified array
    }
}
