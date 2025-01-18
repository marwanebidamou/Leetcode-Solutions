public class Solution {
    public int KthFactor(int n, int k) {
        
        int countFactors = 0;
        int num=1;
        while(num<=n)
        {
            if(n%num==0)
            {
                if(++countFactors == k)
                    return num;
            }
            num++;
        }

        return -1;
    }
}