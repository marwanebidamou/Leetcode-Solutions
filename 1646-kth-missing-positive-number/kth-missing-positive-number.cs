public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        
        int arrIndex=0;
        int missingCount=0;
        int startingNumber = 1;


        while(true)
        {
            if (arrIndex<arr.Length && arr[arrIndex] == startingNumber){
                startingNumber++;    
                arrIndex++;            
            }
            else{
                missingCount++;
                startingNumber++;
            }

            if (missingCount==k)
                return startingNumber-1;
        }
    }
}