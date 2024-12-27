public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        // Dictionary to map each element in nums2 to its "next greater element"
        Dictionary<int, int> nums2Map = new Dictionary<int, int>();

        // Stack to help find the next greater element in nums2
        Stack<int> stack = new Stack<int>();

        // Iterate through nums2 from right to left to find the next greater elements
        for (int i = nums2.Length - 1; i >= 0; i--)
        {
            // Maintain a decreasing stack:
            // Remove elements from the stack that are smaller than the current element
            while (stack.Count > 0 && stack.Peek() < nums2[i])
            {
                stack.Pop(); // Pop smaller elements as they cannot be the next greater for nums2[i]
            }

            // If the stack is not empty, the top of the stack is the next greater element
            // Otherwise, there is no greater element to the right, so assign -1
            nums2Map.Add(nums2[i], stack.Count > 0 ? stack.Peek() : -1);

            // Push the current element onto the stack
            stack.Push(nums2[i]);
        }

        // Create an output array for nums1 with the same length
        int[] output = new int[nums1.Length];

        // Iterate through nums1 and retrieve the next greater elements from the dictionary
        for (int i = 0; i < nums1.Length; i++)
        {
            // If nums1[i] is in the dictionary, get its next greater element
            // Otherwise, assign -1 (though this case won't happen as nums1 is a subset of nums2)
            output[i] = nums2Map.ContainsKey(nums1[i]) ? nums2Map[nums1[i]] : -1;
        }

        // Return the resulting array
        return output;
    }
}
