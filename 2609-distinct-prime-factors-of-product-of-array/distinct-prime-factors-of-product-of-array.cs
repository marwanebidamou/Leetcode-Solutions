public class Solution {
    public int DistinctPrimeFactors(int[] nums) {

        HashSet<int> hash = new HashSet<int>();

        for(int i=0;i<nums.Length;i++)
        {
            hash.UnionWith(GetPrimeFactors(nums[i]));

        }
        return hash.Count();
    }


    HashSet<int> GetPrimeFactors(int number)
    {
        HashSet<int> factors = new HashSet<int>();

        while(number%2==0)
        {
            number = number / 2;
            factors.Add(2);
        }

        for(int i= 3;i<number;i=i+2)
        {
            while(number%i==0)
            {
                number = number / i;
                factors.Add(i);
            }
        }

        if(number>2)
            factors.Add(number);

        return factors;
    }
}