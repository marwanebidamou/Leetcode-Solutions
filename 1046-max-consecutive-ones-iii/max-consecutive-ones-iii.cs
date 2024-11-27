public class Solution {
    public int LongestOnes(int[] nums, int k) {
        
        Queue<int> zeroIndices = new Queue<int>();
        
        int left=0,right=0,longestOnes=0;
        while(right<nums.Length){
            if(nums[right] == 1)
            {
                right++;
            }
            else
            {
                if(zeroIndices.Count<k)
                {
                    zeroIndices.Enqueue(right);                    
                    right++;
                }
                else
                {                   
                    if(zeroIndices.Count>0)
                    {
                        int firstZeroIndex = zeroIndices.Dequeue();
                        left=firstZeroIndex+1;
                    }
                    else
                    {
                        right++;
                        left=right;

                    }
                    
                }
            }
            
            longestOnes=Math.Max(right-left, longestOnes);
            
        }
        
        return longestOnes;
    }
}