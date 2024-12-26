public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] result = new int[n - k + 1];

        var maxHeap = new SortedSet<(int value, int index)>(Comparer<(int value, int index)>.Create(
            (a, b) => a.value == b.value ? a.index.CompareTo(b.index) : b.value.CompareTo(a.value)
        ));

        for (int i = 0; i < n; i++) {
            // Add the current element to the heap
            maxHeap.Add((nums[i], i));

            // Remove elements that are out of the current window
            if (i >= k) {
                maxHeap.Remove((nums[i - k], i - k));
            }

            // Record the max value for the current window
            if (i >= k - 1) {
                result[i - k + 1] = maxHeap.Min.value; // Max element is at the top
            }
        }

        return result;
    }
}