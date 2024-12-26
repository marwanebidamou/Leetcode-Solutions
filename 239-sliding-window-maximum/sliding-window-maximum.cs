public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {

        // Using max heap
        /*
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
        */

        //using Monotonic deque implemented using LinkedList
        // Array to store the result of the sliding window maximums
        int n = nums.Length;
        int[] ans = new int[n - k + 1];
        
        // Create a LinkedList to represent the deque (double-ended queue)
        LinkedList<int> deque = new LinkedList<int>();
        
        // Loop through each element in the nums array
        for (int i = 0; i < nums.Length; i++) {
            
            // Remove elements from the back of the deque if they are smaller
            // than the current element because they will never be the maximum
            // in the sliding window.
            while (deque.Count > 0 && nums[i] > nums[deque.Last.Value]) {
                deque.RemoveLast();
            }
            
            // Add the current index (i) to the deque
            // We are keeping indices, so we store the index of the current element
            deque.AddLast(i);
            
            // Remove the front element if it's out of the window
            // The front of the deque will always be the index of the maximum element
            // in the current sliding window, so if it's out of range, remove it.
            if (deque.First.Value <= i - k) {
                deque.RemoveFirst();
            }
            
            // If the window has reached size k, record the maximum value for the window
            // The maximum element in the current window will always be at the front of the deque
            // because we are maintaining the deque in decreasing order.
            if (i >= k - 1) {
                ans[i - k + 1] = nums[deque.First.Value]; // The value at the front is the maximum
            }
        }
        
        // Return the array of sliding window maximums
        return ans;
    }
}