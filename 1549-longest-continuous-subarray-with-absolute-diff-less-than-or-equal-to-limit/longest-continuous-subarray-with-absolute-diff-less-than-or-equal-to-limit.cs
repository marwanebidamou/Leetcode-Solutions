public class Solution {
    public int LongestSubarray(int[] nums, int limit) {
        // These deques store indices of elements
        // maxQueue: tracks potential maximum values in descending order
        // minQueue: tracks potential minimum values in ascending order
        LinkedList<int> maxQueue = new LinkedList<int>();
        LinkedList<int> minQueue = new LinkedList<int>();

        int maxLength = 0;
        // windowStart: marks the start of our sliding window
        int windowStart = 0;
        
        // windowEnd: marks the end of our sliding window
        for(int windowEnd = 0; windowEnd < nums.Length; windowEnd++) {
            // Remove elements smaller than current from maxQueue
            // This maintains the descending order property
            // Example: if maxQueue has [10,8,7] and current is 9
            // We remove 7,8 to maintain descending order: [10,9]
            while(maxQueue.Count > 0 && nums[maxQueue.Last.Value] < nums[windowEnd]) {
                maxQueue.RemoveLast();
            }
            
            // Remove elements larger than current from minQueue
            // This maintains the ascending order property
            // Example: if minQueue has [5,6,7] and current is 6
            // We remove 7 to maintain ascending order: [5,6,6]
            while(minQueue.Count > 0 && nums[minQueue.Last.Value] > nums[windowEnd]) {
                minQueue.RemoveLast();
            }
            
            // Add current index to both queues
            maxQueue.AddLast(windowEnd);
            minQueue.AddLast(windowEnd);
            
            // Calculate current window's max difference
            // windowMaxValue: largest element in current window
            // windowMinValue: smallest element in current window
            int windowMaxValue = nums[maxQueue.First.Value];
            int windowMinValue = nums[minQueue.First.Value];
            
            // Shrink window if max difference exceeds limit
            while(maxQueue.Count > 0 && minQueue.Count > 0 && 
                  windowMaxValue - windowMinValue > limit) {
                // Remove indices that fall outside the window
                if(maxQueue.First.Value <= windowStart) maxQueue.RemoveFirst();
                if(minQueue.First.Value <= windowStart) minQueue.RemoveFirst();
                // Shrink window from the start
                windowStart++;
                
                // Update max and min values if queues still have elements
                if(maxQueue.Count > 0) windowMaxValue = nums[maxQueue.First.Value];
                if(minQueue.Count > 0) windowMinValue = nums[minQueue.First.Value];
            }
            
            // Calculate current window size and update max length if needed
            int currentWindowSize = windowEnd - windowStart + 1;
            maxLength = Math.Max(maxLength, currentWindowSize);
        }
        
        return maxLength;
    }
}