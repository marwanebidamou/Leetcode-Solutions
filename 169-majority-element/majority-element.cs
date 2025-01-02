public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int majorityCount = (nums.Length+1) / 2;
        for(int i=0;i<nums.Length;i++)
        {
            int itemCount =map.GetValueOrDefault(nums[i]) + 1;
            map[nums[i]]=itemCount;
            if(itemCount == majorityCount)
            {
                return nums[i];
            }
        }
        return -1;
    }
}