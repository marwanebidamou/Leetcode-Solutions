public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        // Initialize cumulative sums:
        // - `prefixSum`: Tracks the cumulative sum of the elements in the input array `arr`.
        // - `sortedPrefixSum`: Tracks the cumulative sum of indices, representing the cumulative sum of the sorted array.
        // - `maxChunks`: Keeps count of valid chunks.
        int prefixSum = 0; 
        int sortedPrefixSum = 0; 
        int maxChunks = 0;

        // Iterate through each index of the array
        for (int i = 0; i < arr.Length; i++) {
            // Add the current array element to the running sum of the array.
            prefixSum += arr[i];
            
            // Add the current index to the running sum of a sorted array's indices.
            sortedPrefixSum += i;

            // Check if the two cumulative sums match at this point.
            // If they match, it guarantees that the current segment of the array
            // (from the last chunk boundary or start) contains exactly the same elements
            // as the corresponding segment of the sorted array.
            if (prefixSum == sortedPrefixSum) {
                // If the sums match, increment the count of valid chunks.
                maxChunks++;
            }
        }

        // Return the total number of chunks that can be formed.
        return maxChunks;
    }
}