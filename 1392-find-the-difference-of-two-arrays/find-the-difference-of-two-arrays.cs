public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> hash1 = new HashSet<int>();
        for(int i=0;i<nums1.Length;i++)
            hash1.Add(nums1[i]);

        HashSet<int> hash2 = new HashSet<int>();
        for(int i=0;i<nums2.Length;i++)
        {
            hash2.Add(nums2[i]);
            hash1.Remove(nums2[i]);
        }

        for(int i=0;i<nums1.Length;i++)
            hash2.Remove(nums1[i]);

        IList<IList<int>> result = new List<IList<int>>();
        result.Add(hash1.ToList());
        result.Add(hash2.ToList());

        return result;

    }
}