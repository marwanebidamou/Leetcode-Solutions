public class Solution {
    public int MaxOperations(int[] nums, int k) {

        Dictionary<int,int> dict = new Dictionary<int,int>();

        foreach(int num in nums){
            if (num>=k)
                continue;

            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num]=1;
        }

        int operationCount=0;
        foreach(int num in nums){
            if (num>=k || dict[num]<1)
                continue;

            dict[num]--;
            int rest = k-num;
            if (dict.ContainsKey(rest) && dict[rest]>0)
            {
                dict[rest]--;
                operationCount++;
            }
        }

        return operationCount;
       
    }
}