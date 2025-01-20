public class Solution {
    public int HIndex(int[] citations) {
        // Step 1: Sort the array in ascending order
        // Sorting helps us analyze the citation counts in increasing order.
        Array.Sort(citations);
        int n = citations.Length; // Total number of papers

        // Step 2: Iterate through the sorted array
        for (int i = 0; i < n; i++) {
            // Calculate the current H-Index candidate
            int hIndex = n - i; // The number of papers with at least hIndex citations

            // Step 3: Check if the current paper's citation count meets the H-Index condition
            if (citations[i] >= hIndex) {
                // If the number of papers with at least hIndex citations is valid,
                // return the current hIndex as the result.
                return hIndex;
            }
        }

        // Step 4: If no H-Index is found, return 0
        // This happens when all papers have fewer citations than their respective H-Index candidate.
        return 0;
    }
}
