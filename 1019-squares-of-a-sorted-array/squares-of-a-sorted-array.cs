public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        int[] result = new int[nums.Length];
        int resultIndex=nums.Length-1;
        
        int left=0,right=nums.Length-1;
        
        while(left<=right){
            int leftNumPw = nums[left]*nums[left];
            int rightNumPw = nums[right]*nums[right];

            if(leftNumPw>rightNumPw){
                result[resultIndex--]=leftNumPw;
                left++;
            }else{
                result[resultIndex--]=rightNumPw;
                right--;
            }
        }
        
        
        return result;
    }
}