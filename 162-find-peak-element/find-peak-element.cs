public class Solution {
    public int FindPeakElement(int[] nums) {
        return Helper(nums, 0, nums.Length-1);        
    }

    public int Helper(int[] nums, int left, int right)
    {
        if(left>right)
            return -1;

        int mid = (left+right)/2;
        if((mid==0 || nums[mid-1]<nums[mid]) && (mid==nums.Length-1 || nums[mid+1]<nums[mid]))
            return mid;
        
        int leftSide = Helper(nums, left, mid-1);
        if(leftSide != -1)
            return leftSide;
        
        return Helper(nums, mid+1, right);        
    }
}