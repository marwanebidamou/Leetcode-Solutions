public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {

        if (n==0)
            return true;
            
        if (flowerbed.Length == 0)
            return false;

        if (flowerbed.Length==1)
            if (flowerbed[0]==1)
                return false;
            else
                return n==1;

        

        int pointer = 0;
        while(pointer<flowerbed.Length){
            if (flowerbed[pointer]==0)
            {
                bool isLeftAvailable = pointer-1<0 || flowerbed[pointer-1]==0;
                bool isRightAvailable = pointer+1>flowerbed.Length-1 || flowerbed[pointer+1]==0;

                if (isLeftAvailable && isRightAvailable)
                {
                    flowerbed[pointer]=1;
                    n--;
                }

            }
            if (n<=0)
                return true;

            pointer++;
        }

        return false;
        
    }
}