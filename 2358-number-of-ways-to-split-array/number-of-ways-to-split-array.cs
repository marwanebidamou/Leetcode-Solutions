public class Solution {
    public int WaysToSplitArray(int[] nums) {
        if(nums.Length<2)
            return 0;

        long[] sumArray = new long[nums.Length];

        sumArray[0] = nums[0];

        for(int i=1;i<nums.Length;i++)
        {
            sumArray[i]=sumArray[i-1] + nums[i];
        }

        int validSplitsCount = 0;
        for(int i=0;i<nums.Length-1;i++)
        {
            long firstPart = sumArray[i];
            long lastPart = sumArray[nums.Length-1] - sumArray[i];
            
            if( firstPart >= lastPart )
                validSplitsCount++;
        }

        return validSplitsCount;

    }
}