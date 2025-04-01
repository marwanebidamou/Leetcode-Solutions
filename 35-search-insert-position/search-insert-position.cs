public class Solution {
    public int SearchInsert(int[] nums, int target) {
    int left = 0;
    int right = nums.Length - 1;
        if (target <= nums[0]) return 0;
        if (target > nums[right]) return nums.Length;

        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            if(nums[mid] == target)
                return mid;
            
            left = nums[mid] < target ? mid + 1 : left;
            right = nums[mid] > target ? mid - 1 : right;            
        }

        return left;
    }

}