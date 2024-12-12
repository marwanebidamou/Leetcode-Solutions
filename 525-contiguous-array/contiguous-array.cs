public class Solution {
    public int FindMaxLength(int[] nums) {
        int sum = 0;
        int maxLength = 0;
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            sum+=(nums[i]==0?-1:1);

            if(sum==0)
            {
                maxLength=i+1;
            }
            else if(map.ContainsKey(sum)){
                Console.WriteLine(sum);
                maxLength = Math.Max(maxLength, i-map[sum]);
            }

             if(!map.ContainsKey(sum))
                map.Add(sum,i);
            
        }
        return maxLength;
    }
}