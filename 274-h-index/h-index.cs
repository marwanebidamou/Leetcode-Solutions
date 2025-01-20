public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        int n = citations.Length;

        for (int i = 0; i < n; i++) {
            int hIndex = n - i;
            if (citations[i] >= hIndex) {
                return hIndex;
            }
        }
        return 0;
    }
}
