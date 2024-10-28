public class Solution {
    public int ClimbStairs(int n)
    {
        if (n<2)
            return 1;

        
        int minusStep=1;
        int minus2Steps = 2;

        for(int i=2;i<n;i++){
            int tmp = minusStep;
            minusStep = minus2Steps;
            minus2Steps = minus2Steps + tmp;
        }

        return minus2Steps;   
    }

}