public class Solution {

    Dictionary<int,bool> dict = new Dictionary<int,bool>();

    public bool CanJump(int[] nums) {
        return CanJumpFromPosition(position: 0, nums);
    }

    public bool CanJumpFromPosition(int position, int[] nums) {
        if (position == nums.Length - 1)
            return true;
        
        if(dict.ContainsKey(position))
            return dict[position];
        
        for(int i=1;i<=nums[position];i++)
        {
            if(CanJumpFromPosition(position+i, nums))
                return true;
        }
        dict[position] = false;
        return false;
    }

}