public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit=0;
        int minPrice=prices[0];

        foreach(var price in prices)
        {
            if (minPrice>price)
                minPrice = price;
            
            maxProfit = Math.Max(maxProfit, price-minPrice);
        }

        return maxProfit;
    }
}