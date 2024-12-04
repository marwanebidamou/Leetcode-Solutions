public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if(k <=1 || nums.Length == 0)
            return 0;

        int left=0, right=0, totalSubArrays = 0;

        int product=1;

        for(right=0; right<nums.Length; right++){
            // Expand the window by including the element at the right pointer
            product *= nums[right];

            // Shrink the window from the left while the product is greater than or equal to k
            while(product >= k){
                // Remove the element at the left pointer from the product
                product /= nums[left];
                left++;
            }
            
             // Update the total count by adding the number of valid subarrays with the current window size
            totalSubArrays += right - left + 1; // right - left + 1 represents the current window size
            
        }

        return totalSubArrays;
    }
}