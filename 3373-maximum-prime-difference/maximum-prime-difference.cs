public class Solution {
    public int MaximumPrimeDifference(int[] nums) {
       int left = 0, right=nums.Length-1;

        while(left<nums.Length)
        {   
            if(!isPrime(nums[left]))
                left++;
            else{
                break;
            } 
        }

        while(right>=left)
        {   
            if(!isPrime(nums[right]))
                right--;
            else {
                return right-left;
            } 
        }
        return 0;        
    }

    private bool isPrime(int number)
    {
        if(number < 2)
            return false;
            
        for(int i=number-1; i> 1;i--)
        {
            if(number%i==0)
                return false;
        }
        return true;
    }
}