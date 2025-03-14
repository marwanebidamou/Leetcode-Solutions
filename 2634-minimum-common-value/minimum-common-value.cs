public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        
        int i1 = 0, i2 = 0;

        while(i1<nums1.Length && i2<nums2.Length) {

            if(nums1[i1] == nums2[i2])
                return nums1[i1];
            else if(nums1[i1] < nums2[i2])
                i1++;
            else
                i2++;
        }

        return -1;
    }
}