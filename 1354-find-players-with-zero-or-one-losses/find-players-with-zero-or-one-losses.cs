public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {

        IList<IList<int>> result = new List<IList<int>>
        {
            new List<int>(),
            new List<int>()
        };

        Dictionary<int,int> lossCount = new Dictionary<int,int>();
        
        for(int i=0;i<matches.Length;i++)
        {
            lossCount[matches[i][1]] = lossCount.GetValueOrDefault(matches[i][1])+1;
            lossCount[matches[i][0]] = lossCount.GetValueOrDefault(matches[i][0])+0;
        }

        foreach(var loss in lossCount.OrderBy(x=>x.Key)){
            if(loss.Value==0)
                result[0].Add(loss.Key);
            else if(loss.Value==1)
                result[1].Add(loss.Key);
        }

        return result;
    }
}