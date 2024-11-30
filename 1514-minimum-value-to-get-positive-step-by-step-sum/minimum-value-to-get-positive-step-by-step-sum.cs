public class Solution {
    public int MinStartValue(int[] nums) {

        /** 
        // Solving the problem using the brute force approach 

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

        */


        /*
        */
        // Solving the problem using the binary search approach 

        // Let n be the length of the array "nums", m be the absolute value 
        // of the lower boundary of the element. In this question we have m = 100.

        int left = 1;        
        int right = 100 * nums.Length + 1; // 100 is the absolute value of the lower boundary of the element

        while(left<right){
            int middle = (left + right) / 2;
            int total = middle;
            bool isValid = true;

            for(int i=0;i<nums.Length;i++)
            {
                total+=nums[i];
                if(total<1)
                {
                    isValid = false;
                    break;
                }
            }

            if(isValid)
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        return left;        
    }
}