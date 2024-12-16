public class Solution {
    public int EqualPairs(int[][] grid) {
        
        int n=grid.Length;
        Dictionary<string, int> mapRows = new Dictionary<string, int>();
        Dictionary<string, int> mapCols = new Dictionary<string, int>();

        for(int i=0;i<n;i++)
        {
            string row = "";
            string column = "";

            for(int j=0;j<n;j++)
            {
                row+="-"+grid[i][j];
                column+="-"+grid[j][i];
            }

            mapRows[row] = mapRows.GetValueOrDefault(row)+1;
            mapCols[column] = mapCols.GetValueOrDefault(column)+1;        
        }

        int countOfEqualPairs = 0;
        foreach(var item in mapRows)
        {
           if(mapCols.ContainsKey(item.Key)){
                countOfEqualPairs+=item.Value*mapCols[item.Key];
           }
        }

        return countOfEqualPairs;
    }
}