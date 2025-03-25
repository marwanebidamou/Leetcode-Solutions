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
                return powerOfA.CompareTo(powerOfB);
            }
            else
            {
                return a.CompareTo(b);
            }
        });

        return list[k-1];
    }

    Dictionary<int,int> memo = new Dictionary<int,int>();
    int GetPowerValue(int number)
    {
        if(number == 1)
            return 0;

        if(memo.ContainsKey(number))
            return memo[number];

  

        int n=number;
        
        int next = n % 2==0 ? n / 2 : 3 * n + 1;
        int power = 1 + GetPowerValue(next);
        memo[n] = power;
        return memo[n];
    }
}