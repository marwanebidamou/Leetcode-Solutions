public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        int result = 0;

        int oddCount = 0;
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(0,1);

        for(int i=0; i< nums.Length; i++)
        {
            oddCount += nums[i]%2==1?1:0;

            int toAdd = 0;
            map.TryGetValue(oddCount - k, out toAdd);
            result+=toAdd;               

            if(map.ContainsKey(oddCount))
            {
                map[oddCount]++;
            }
            else {
                map[oddCount]=1;
            }

        }
        return result;
    }
}