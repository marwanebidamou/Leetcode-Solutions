public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        bool[] visited = new bool[n]; // Tracks visited cities
        int provinces = 0;

        // Helper function to perform DFS
        void DFS(int city) {
            for (int neighbor = 0; neighbor < n; neighbor++) {
                // If there's a connection and the neighbor hasn't been visited
                if (isConnected[city][neighbor] == 1 && !visited[neighbor]) {
                    visited[neighbor] = true;
                    DFS(neighbor); // Visit the neighbor
                }
            }
        }

        // Iterate through all cities
        for (int city = 0; city < n; city++) {
            if (!visited[city]) {
                provinces++;
                visited[city] = true;
                DFS(city); // Start a DFS from the unvisited city
            }
        }

        return provinces;
    }
}
