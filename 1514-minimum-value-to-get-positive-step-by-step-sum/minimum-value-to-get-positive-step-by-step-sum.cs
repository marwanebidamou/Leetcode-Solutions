public class Solution {
    public int MinStartValue(int[] nums) {

        /** 
        // Solving the problem using the brute force approach 
        */
        
        int startValue=1;

        while(true)
        {
            int sum=startValue;
            bool isValidValue=true;
            for(int i=0;i<nums.Length && isValidValue;i++)
            {
                sum+=nums[i];
                if(sum<1)
                    isValidValue=false;
            }
            if(isValidValue)
                return startValue;
            else
                startValue++;
        }

        return startValue; 
    }
}