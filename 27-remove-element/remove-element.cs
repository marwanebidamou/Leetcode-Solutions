public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length==0)
            return 0;
        

        int leftPointer = 0;
        int rightPointer = nums.Length-1;

        int k=nums.Length;

        while(leftPointer<=rightPointer){         

            if (nums[leftPointer] == val){
                k--;
                nums[leftPointer] = nums[rightPointer--];
            } else {
                leftPointer++;
            }               
        }

        return k;
    }
}