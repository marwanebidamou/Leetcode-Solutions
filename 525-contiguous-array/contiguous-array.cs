public class Solution {
    public int FindMaxLength(int[] nums) {
        // Initialize sum to track the difference between 0s and 1s
        int sum = 0;
        
        // Track the maximum length of contiguous subarray with equal 0s and 1s
        int maxLength = 0;
        
        // Dictionary to store first occurrence of each cumulative sum
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        // Iterate through the array
        for(int i=0;i<nums.Length;i++)
        {
            // Convert 0 to -1 and 1 to 1 to transform the problem
            // This helps in finding subarrays with equal 0s and 1s
            sum += (nums[i] == 0 ? -1 : 1);

            // If sum is 0, it means we have equal 0s and 1s from start
            if(sum == 0)
            {
                // Update max length to current index + 1
                maxLength = i + 1;
            }
            // If we've seen this sum before, we found a valid subarray
            else if(map.ContainsKey(sum)){
                // Calculate and update max length
                // Current index - first occurrence of this sum gives subarray length
                maxLength = Math.Max(maxLength, i - map[sum]);
            }
            else{
                // Store the first occurrence of this sum
                map.Add(sum, i);
            }            
        }
        return maxLength;
    }
}