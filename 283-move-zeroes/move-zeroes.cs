public class Solution {
    public void MoveZeroes(int[] nums) {
        int index = 0;
        int actualIndex=0;

        while(index<nums.Length)
        {
            if(nums[index]!=0)
            {
                nums[actualIndex++] = nums[index];                
            }
            index++;
        }

        
        while(actualIndex<nums.Length)
        {
            nums[actualIndex++]=0;
        }
    }
}