public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int sum = 0;
        int sortedSum = 0;
        int maxChunks = 0;
        for(int i=0;i<arr.Length;i++)
        {
            sortedSum+=i;
            sum+=arr[i];

            if(sortedSum == sum)
                maxChunks++;
        }
        return maxChunks;
    }
}