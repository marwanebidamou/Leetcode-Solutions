public class Solution {
    public int LargestUniqueNumber(int[] nums) {

        Array.Sort(nums, Comparer<int>.Create((a,b)=>b-a));

        Dictionary<int,int> map = new Dictionary<int,int>();

        int lastNumber = nums[0], lastNumberCount = 1;
        
        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i]!=lastNumber)
            {
                if(lastNumberCount == 1)
                    return lastNumber;
                else
                    lastNumberCount = 1;
            }
            else
            {
                lastNumberCount++;
            }
            lastNumber = nums[i];
        }

        return lastNumberCount == 1 ? lastNumber : -1;
    }
}