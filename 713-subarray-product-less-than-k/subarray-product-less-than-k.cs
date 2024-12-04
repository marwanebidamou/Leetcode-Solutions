public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if(k <=1 || nums.Length == 0)
            return 0;

        int left=0, right=0, totalSubArrays = 0;

        int product=1;

        while(right<nums.Length){

            product*=nums[right];

            if(product<k){
                totalSubArrays += right - left + 1;
            }
            else{
                while(product>=k && left<nums.Length){
                    product /= nums[left];
                    left++;
                }
                if(product<k){
                    totalSubArrays += right - left + 1;
                }
            }  
            right++;

        }

        return totalSubArrays;
    }
}