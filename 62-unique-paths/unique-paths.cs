public class Solution {
    public int UniquePaths(int m, int n) {

        Dictionary<string,int> memo = new Dictionary<string,int>();

        return UniquePathsHelper(m,n,memo);
    }

    public int UniquePathsHelper(int m, int n, Dictionary<string,int> memo) {

        if (m== 0 || n==0) //empty grid
            return 0;

        if (m == 1 && n == 1) //1x1 grid: there is only way which is we do nothing
            return 1;
        

        int topCellPaths;
        var memoTopKey = Math.Min(m-1, n)+"-"+Math.Max(m-1, n);

        if (memo.ContainsKey(memoTopKey)){
            Console.WriteLine(memoTopKey);
            topCellPaths=memo[memoTopKey];
        }
        else{
            topCellPaths=UniquePathsHelper(m-1, n, memo);
            memo.Add(memoTopKey, topCellPaths); 
        }

        int leftCellPaths;
        var memoLeftKey = Math.Min(m, n-1)+"-"+Math.Max(m, n-1);
        
        if (memo.ContainsKey(memoLeftKey)){
            Console.WriteLine(memoLeftKey);
            leftCellPaths=memo[memoLeftKey];
        }
        else{
            leftCellPaths=UniquePathsHelper(m, n-1, memo);
            memo.Add(memoLeftKey, leftCellPaths); 
        }
        
        return  leftCellPaths + topCellPaths; 
    }

}