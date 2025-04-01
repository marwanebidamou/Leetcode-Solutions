public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int start = 0;
        int end = nums.Length - 1;
        int foundIndex = -1;
        while(start <= end)
        {
            int mid = start + (end - start) / 2;
            if(nums[mid] == target)
            {
                foundIndex = mid;
                break;
            }
            else if(nums[mid] < target)
                start = mid + 1;
            else
                end = mid - 1;
        }

        if(foundIndex == -1)
            return new int[2] {-1,-1};
        else
        {
            int left = foundIndex, right = foundIndex;

            while(left > 0 && nums[left-1] == target)
                left--;
            while(right < nums.Length-1 && nums[right+1] == target)
                right++;

            
            return new int[2] {left,right};
            
        }
    }
}