public class Solution {
    public int NumberOfChild(int n, int k) {
        

        int current=1;
        bool directionLeftToRight = true;
        while(k>0)
        {
            if(directionLeftToRight)
            {
                if(current == n){
                    directionLeftToRight = false;
                    current--;
                }
                else
                {
                    current++;
                }            
            }
            else
            {
                if(current==1){
                    directionLeftToRight = true;
                    current++;
                }
                else
                {
                    current--;
                }
            }

            k--;
        }

        return current-1;


    }
}