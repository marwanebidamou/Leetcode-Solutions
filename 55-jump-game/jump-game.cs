public class Solution {
    public bool CanJump(int[] nums) {
        int maxReach = 0;
        int n=nums.Length-1;
        for(int i=0;i<=n;i++)
        {
            if(i > maxReach)
                return false;
            
            maxReach = Math.Max(maxReach, i+nums[i]);

            if(maxReach >= n)
                return true;

        }

        return false;
    }
}