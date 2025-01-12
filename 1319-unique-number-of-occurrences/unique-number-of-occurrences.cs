public class Solution {
    public bool UniqueOccurrences(int[] arr) {        

        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i=0;i<arr.Length;i++)
        {
            map[arr[i]]=map.GetValueOrDefault(arr[i])+1;
        }

        return map.Count == map.Values.Distinct().Count();

    }
}