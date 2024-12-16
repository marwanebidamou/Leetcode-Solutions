public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        HashSet<char> jewelsMap = new HashSet<char>(jewels);

        int numberOfJewels = 0;
        for(int i=0;i<stones.Length;i++)
        {
            if(jewelsMap.Contains(stones[i]))
            {
                numberOfJewels++;
            }
        }

        return numberOfJewels;
    }
}