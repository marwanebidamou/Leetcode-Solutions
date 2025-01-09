public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        int min = 1; // Minimum possible speed
        int max = piles.Max(); // Maximum pile size

        return Helper(piles, h, min, max);
    }

    public int Helper(int[] piles, int h, int min, int max)
    {
        if (min >= max) return min; // Base case: when min equals or exceeds max

        int mid = min + (max - min) / 2; // Calculate mid using integer arithmetic      

        var countHours = CountHours(piles, mid);

        if (countHours <= h)
        {
            // If hours are within the limit, try to reduce the speed
            return Helper(piles, h, min, mid);
        }
        else
        {
            // If hours exceed the limit, increase the speed
            return Helper(piles, h, mid + 1, max);
        }
    }

    public int CountHours(int[] piles, int k)
    {
        int nbrHours = 0;
        for(int i=0;i<piles.Length;i++)
        {
            nbrHours += (int)Math.Ceiling((double)piles[i] / k);
        }
        return nbrHours;
    }
}