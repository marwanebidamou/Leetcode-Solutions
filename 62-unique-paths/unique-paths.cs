public class Solution {
    public int UniquePaths(int m, int n) {

        Dictionary<string,int> memo = new Dictionary<string,int>();

        return UniquePathsHelper(m,n,memo);
    }

    public int UniquePathsHelper(int m, int n, Dictionary<string,int> memo) {

        var memoKey = Math.Min(m,n)+","+Math.Max(m,n);

        if (memo.ContainsKey(memoKey)){
            return memo[memoKey];
        }

        if (m== 0 || n==0) //empty grid
            return 0;

        if (m == 1 && n == 1) //1x1 grid: there is only way which is we do nothing
            return 1;
        
        memo[memoKey] = UniquePathsHelper(m-1, n, memo) +  UniquePathsHelper(m, n-1, memo);
        
        return memo[memoKey] ; 
    }
}