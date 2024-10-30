public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] prefixProduct = new int[nums.Length];
        int[] suffixProduct = new int[nums.Length];

        int prefixIndex=0;
        int suffixIndex=nums.Length-1;

        int prefixSum=1;
        int suffixSum=1;

        while(prefixIndex<nums.Length){

            prefixSum*=nums[prefixIndex];
            prefixProduct[prefixIndex] = prefixSum;
            prefixIndex++;

            suffixSum*=nums[suffixIndex];
            suffixProduct[suffixIndex] = suffixSum;
            suffixIndex--;
        }

        for(int i=0;i<nums.Length;i++){
            if (i>0 && i<nums.Length-1)                
                nums[i]=prefixProduct[i-1] * suffixProduct[i+1];
            else if (i>0)
                nums[i]=prefixProduct[i-1];
            else if (i<nums.Length-1)
                nums[i]=suffixProduct[i+1];
        }
        return nums;        
    }
}