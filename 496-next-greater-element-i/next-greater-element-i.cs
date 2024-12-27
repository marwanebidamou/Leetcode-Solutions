public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        
        Dictionary<int,int> nums2Map= new Dictionary<int,int>();
        Stack<int> stack = new Stack<int>();

        for(int i=nums2.Length-1;i>=0;i--)
        {
            while(stack.Count > 0 && nums2[stack.Peek()] < nums2[i])
            {
                stack.Pop();
            }

            nums2Map.Add(nums2[i], stack.Count>0 ? nums2[stack.Peek()] : -1);
            stack.Push(i);
        }

        int[] output = new int[nums1.Length];
        for(int i=0;i<nums1.Length;i++)
        {
            output[i] = nums2Map.ContainsKey(nums1[i]) ? nums2Map[nums1[i]] : -1;
        }

        return output;        
    }
}