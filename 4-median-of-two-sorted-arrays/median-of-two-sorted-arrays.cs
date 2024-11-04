public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        //Brute-force method
        int[] combinedNums = new int[nums1.Length+nums2.Length];
        int nums1Index=0;
        int nums2Index=0;
        int combinedIndex=0;

        while(nums1Index<nums1.Length && nums2Index<nums2.Length){
            if (nums1[nums1Index]<=nums2[nums2Index])
            {
                combinedNums[combinedIndex++] = nums1[nums1Index++];
            }
            else
            {
                combinedNums[combinedIndex++] = nums2[nums2Index++];
            }
        }

        while(nums1Index<nums1.Length)
            combinedNums[combinedIndex++] = nums1[nums1Index++];

         while(nums2Index<nums2.Length)
            combinedNums[combinedIndex++] = nums2[nums2Index++];




        if (combinedNums.Length%2==1)
            return combinedNums[combinedNums.Length/2];
        else
        {
            return (double)(combinedNums[(combinedNums.Length/2)-1]+combinedNums[combinedNums.Length/2])/2;

        }

    }
}