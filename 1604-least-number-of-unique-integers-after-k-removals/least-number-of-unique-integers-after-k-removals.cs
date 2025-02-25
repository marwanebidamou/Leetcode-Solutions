public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        // Step 1: Count frequency of each number
        foreach (int num in arr) {
            freq[num] = freq.GetValueOrDefault(num, 0) + 1;
        }

        // Step 2: Sort numbers by frequency (ascending)
        var sortedFrequencies = freq.Values.OrderBy(x => x).ToList();

        int uniqueCount = sortedFrequencies.Count; // Initial number of unique elements

        // Step 3: Remove elements with the lowest frequency first
        foreach (int count in sortedFrequencies) {
            if (k >= count) {
                k -= count; // Remove these elements
                uniqueCount--; // Reduce unique count
            } else {
                break; // Stop when k is exhausted
            }
        }

        return uniqueCount;
    }
}
