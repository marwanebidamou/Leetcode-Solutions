public class Solution {
    Dictionary<int,int> dict = new Dictionary<int,int>();

    public int CoinChange(int[] coins, int amount) {        

        if (amount == 0)
            return 0;

        if (dict.ContainsKey(amount)){
            return dict[amount];
        }

        int min=int.MaxValue;
        foreach(var coin in coins){
            var remain = amount - coin;
            if (remain < 0)
            {
                continue;
            }
            else{
                var coinChange =CoinChange(coins,remain);
                if (coinChange!=-1)
                    min = Math.Min(min, 1 + coinChange);
            }
        }

        var result= min==int.MaxValue ? -1 : min;
        dict.Add(amount,result);
        return result;
    }
}