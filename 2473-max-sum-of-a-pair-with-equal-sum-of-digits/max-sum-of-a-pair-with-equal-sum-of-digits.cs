public class Solution {
    public int MaximumSum(int[] nums) {
        Dictionary<int,int[]> map = new Dictionary<int,int[]>();

        int maximumSum = -1;

        for(int i=0;i<nums.Length;i++)
        {
            int currentNumberDigitsSum = 0;
            int currentNumber = nums[i];

            while(currentNumber>0){
                currentNumberDigitsSum += currentNumber%10;
                currentNumber/=10;
            }

            if(!map.ContainsKey(currentNumberDigitsSum))
            {
                map.Add(currentNumberDigitsSum, new int[2]{nums[i],0});
            }
            else
            {
                int[] vals = map[currentNumberDigitsSum];

                if(vals[1]==0)
                    vals[1] = nums[i];
                else if (vals[0]<nums[i] && vals[1]<nums[i])
                {
                    vals[0] = Math.Max(vals[0], vals[1]);
                    vals[1] = nums[i];
                }
                else if(vals[0]<nums[i])
                    vals[0] = nums[i];
                else if(vals[1]<nums[i])
                    vals[1] = nums[i];

                maximumSum = Math.Max(maximumSum, vals[0] + vals[1]);
            }
        }

        return maximumSum;
    }
}