public class Solution
{
    public int DistinctPrimeFactors(int[] nums)
    {
        HashSet<int> hash = new HashSet<int>();

        foreach (int num in nums)
        {
            hash.UnionWith(GetPrimeFactors(num));
        }
        
        return hash.Count;
    }

    private HashSet<int> GetPrimeFactors(int number)
    {
        HashSet<int> factors = new HashSet<int>();

        // Factor out 2 to handle even numbers.
        while (number % 2 == 0)
        {
            factors.Add(2);
            number /= 2;
        }

        // Check odd numbers up to the square root of 'number'.
        for (int i = 3; i * i <= number; i += 2)
        {
            while (number % i == 0)
            {
                factors.Add(i);
                number /= i;
            }
        }

        // If 'number' is still greater than 2, it is prime.
        if (number > 2)
        {
            factors.Add(number);
        }

        return factors;
    }
}