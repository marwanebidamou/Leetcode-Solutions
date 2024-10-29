public class Solution {
    public int MaxProfit(int[] prices) {
        
        int max=0;
        int minPrice=prices[0];

        foreach(var price in prices)
        {
            if (minPrice>price)
                minPrice = price;
            
            max = Math.Max(max, price-minPrice);
        }

        return max;
    }
}