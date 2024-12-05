public class Solution {
    public int SubarraySum(int[] nums, int k) {

        // Bruteforce solution
        /*
        int total=0;
        for(int left=0, right=0;left<nums.Length;left++)
        {
            int sum=0;

            for(int j=left;j<nums.Length;j++){
                sum+=nums[j];
                if(sum==k)
                    total++;
            }
        }

        return total;
        */

        // running sun + hashmap
         // Initialize variables
        int count = 0; // This will store the total number of subarrays with sum equal to k
        int sum = 0;   // Running sum to keep track of cumulative sum at each point in the array
        Dictionary<int, int> map = new Dictionary<int, int>(); // HashMap to store frequency of running sums

        // Add an initial entry to the map: sum 0 appears once
        // This helps account for subarrays that directly start from the beginning of the array
        map.Add(0, 1);

        // Iterate over the array to calculate running sums
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i]; // Update the running sum by adding the current element

            // Check if there exists a previous running sum (sum - k) in the map
            // If found, it means there's a subarray ending at the current index with sum equal to k
            int toAdd = 0;
            map.TryGetValue(sum - k, out toAdd); // Get the count of such sums, or 0 if not found
            count += toAdd; // Add the count to the total number of valid subarrays

            // Update the map with the current running sum
            if (map.ContainsKey(sum)) {
                map[sum]++; // Increment the frequency if the running sum already exists in the map
            } else {
                map.Add(sum, 1); // Otherwise, add the running sum with a frequency of 1
            }
        }

        // Return the total count of subarrays with sum equal to k
        return count;
    }
}