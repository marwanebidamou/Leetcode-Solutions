public class Solution {
    public int MinimumCardPickup(int[] cards) {
        Dictionary<int,int> map = new Dictionary<int,int>();

        int min=cards.Length+1;
        for(int i=0;i<cards.Length;i++)
        {
            if(!map.ContainsKey(cards[i]))
            {
                map[cards[i]]=i;
            }
            else{
                min=Math.Min(min,i-map[cards[i]]+1);
                map[cards[i]]=i;
            }
        }
        return min==cards.Length+1 ? -1 : min;
    }
}