public class Solution {
    public int SumOfUnique(int[] nums) {
       
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int num in nums)
        {
            map[num]=map.GetValueOrDefault(num) + 1;
        }

        int sum = 0;
        foreach(var item in map)
        {
            sum += (item.Value == 1) ? item.Key : 0;
        }
        return sum; 
    }
}