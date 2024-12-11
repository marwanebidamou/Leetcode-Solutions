public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        int result = 0;
        int oddCount = 0;
        Dictionary<int, int> map = new Dictionary<int, int> {
            { 0, 1 } // To handle cases where a subarray starts at index 0
        };

        foreach (int num in nums) {
            // Increment oddCount if the current number is odd
            if (num % 2 == 1) {
                oddCount++;
            }

            // Find the number of subarrays ending at the current position
            map.TryGetValue(oddCount - k, out int matchingPrefixCount);
            result += matchingPrefixCount;

            // Update the map with the current oddCount
            map[oddCount] = map.GetValueOrDefault(oddCount) + 1;
        }

        return result;
    }
}
