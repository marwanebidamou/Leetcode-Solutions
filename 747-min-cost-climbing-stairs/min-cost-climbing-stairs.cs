public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        
        if (n == 1) return cost[0];
        if (n == 2) return Math.Min(cost[0], cost[1]);
        
        // Dynamic programming variables for previous two steps
        int first = cost[0];
        int second = cost[1];
        
        for (int i = 2; i < n; i++) {
            int current = cost[i] + Math.Min(first, second);
            first = second;
            second = current;
        }
        
        // The minimum cost to reach the top can be from the last step or the second-to-last
        return Math.Min(first, second);
    }
}
