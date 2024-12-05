public class Solution {
    public IList<int> Intersection(int[][] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int rowsCount = nums.Length;
        for(int i=0;i<rowsCount;i++)
        {
            for(int j=0;j<nums[i].Length;j++)
            {
                if(dict.ContainsKey(nums[i][j]))
                {
                    dict[nums[i][j]]++;
                }
                else
                {
                    dict[nums[i][j]]=1;
                }
            }
        }

        List<int> result = new List<int>();

        foreach(var keyValue in dict){
            if(keyValue.Value == rowsCount)
            {
                result.Add(keyValue.Key);
            }
        }

        return result.OrderBy(x=>x).ToList();
    }
}