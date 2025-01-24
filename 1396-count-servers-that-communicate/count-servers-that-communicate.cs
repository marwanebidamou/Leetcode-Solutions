public class Solution {
    public int CountServers(int[][] grid) {

        int[] nbrInrows = new int[grid.Length];
        int[] nbrInColumns = new int[grid[0].Length];

        // Count servers in each row and column
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1) {
                    nbrInrows[i]++;
                    nbrInColumns[j]++;
                }
            }
        }

        int totalCommunicateServers = 0;

        // Count servers that can communicate
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                // A server can communicate if there are more than 1 server in its row or column
                if (grid[i][j] == 1 && (nbrInrows[i] > 1 || nbrInColumns[j] > 1)) {
                    totalCommunicateServers++;
                }
            }
        }

        return totalCommunicateServers;
    }
}
