public class Solution {
    public int GetKth(int lo, int hi, int k) {

        List<int> list = new List<int>();

        for(int i=lo;i<=hi;i++)
        {
            list.Add(i);
        }

        list.Sort((a,b) => {
            int powerOfA = GetPowerValue(a);
            int powerOfB = GetPowerValue(b);

            if(powerOfA != powerOfB)
            {
                return powerOfA-powerOfB;
            }
            else
            {
                return a-b;
            }
        });

        return list[k-1];
    }

    int GetPowerValue(int number)
    {
        int n=number;
        int steps = 0;
        while(n!=1)
        {
            steps++;
            if(n % 2==0)
                n = n / 2;
            else
                n = 3 * n + 1;
        }

        return steps;
    }
}