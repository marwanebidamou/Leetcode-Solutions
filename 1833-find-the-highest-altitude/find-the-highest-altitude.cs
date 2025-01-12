public class Solution {
    public int LargestAltitude(int[] gain) {
        
        int largestAltitude = 0;
        int sum = 0;

        for(int i=0;i<gain.Length;i++)
        {
            sum+=gain[i];
            largestAltitude = Math.Max(largestAltitude, sum);
        }

        return largestAltitude;
    }
}