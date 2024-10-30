public class Solution {
    public int MaxArea(int[] height) {
        
        int leftPointer = 0;
        int rightPointer= height.Length-1;

        int maxAreaValue=0;
        while(leftPointer<rightPointer){
            
            var minHeight = Math.Min(height[leftPointer], height[rightPointer]);
            maxAreaValue = Math.Max(maxAreaValue, minHeight * (rightPointer-leftPointer));

            if (height[leftPointer]< height[rightPointer])
                leftPointer++;
            else
                rightPointer--;
        }
        
        return maxAreaValue;
    }
}