public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int sum=0;
        double avg=0, maxAvg=0;
        
        int left=0, right=0;
    
        while(right<k && right<nums.Length){
            sum+=nums[right];
            avg=(double)sum/(double)(right-left+1);
            maxAvg=avg;
            right++;
        }
                
        while(right<nums.Length){          
            sum-=nums[left];
            sum+=nums[right];
            avg=((double)sum) / (double)k;
            maxAvg = avg > maxAvg ? avg : maxAvg;
            left++;
            right++;
        }
        
        return maxAvg;
        
    }
}