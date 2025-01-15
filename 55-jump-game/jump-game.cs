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
        
        int furthestJump = Math.Min(position + nums[position], nums.Length - 1);

        for (int nextPosition = furthestJump; nextPosition > position; nextPosition--)
        {
            if(CanJumpFromPosition(nextPosition, nums))
                return true;
        }
        dict[position] = false;
        return false;
    }

}