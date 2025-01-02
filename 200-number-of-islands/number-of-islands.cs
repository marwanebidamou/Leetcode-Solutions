public class Solution {
    public int NumIslands(char[][] grid) {
        // Initialize variables for rows and columns
        int rowsCount = grid.Length;
        int colsCount = grid[0].Length;

        // Track visited cells using a boolean array
        bool[] visited = new bool[colsCount * rowsCount];
        
        // Count of total lands ('1') in the grid
        int landsCount = 0;

        // Graph representation: adjacency list for connected lands
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

        // Build the graph from the grid
        for (int i = 0; i < rowsCount; i++) {
            for (int j = 0; j < colsCount; j++) {
                if (grid[i][j] == '1') {
                    int node = colsCount * i + j; // Unique identifier for the cell
                    List<int> neighbors = new List<int>();

                    // Check and add valid neighbors (4 directions)
                    if (j > 0 && grid[i][j - 1] == '1') // Left neighbor
                        neighbors.Add(colsCount * i + (j - 1));
                    if (j < colsCount - 1 && grid[i][j + 1] == '1') // Right neighbor
                        neighbors.Add(colsCount * i + (j + 1));
                    if (i > 0 && grid[i - 1][j] == '1') // Top neighbor
                        neighbors.Add(colsCount * (i - 1) + j);
                    if (i < rowsCount - 1 && grid[i + 1][j] == '1') // Bottom neighbor
                        neighbors.Add(colsCount * (i + 1) + j);

                    // Add node and neighbors to the graph
                    graph[node] = neighbors;
                    visited[node] = false; // Mark as unvisited initially
                    landsCount++; // Count total land cells
                }
            }
        }

        // Traverse the graph to count islands
        int visitedCount = 0; // Number of visited land cells
        int numberOfIslands = 0; // Total number of islands found

        while (visitedCount < landsCount) {
            // Find the next unvisited land cell
            int land = -1;
            foreach (var key in graph.Keys) {
                if (!visited[key]) {
                    land = key;
                    break;
                }
            }

            // Start a new island and mark all connected cells
            numberOfIslands++;
            Stack<int> stack = new Stack<int>();
            stack.Push(land);
            visited[land] = true;
            visitedCount++;

            // Depth-First Search (DFS) using a stack
            while (stack.Count > 0) {
                int currentLand = stack.Pop();
                foreach (var neighbor in graph[currentLand]) {
                    if (!visited[neighbor]) {
                        visited[neighbor] = true; // Mark neighbor as visited
                        stack.Push(neighbor); // Add to stack for further traversal
                        visitedCount++;
                    }
                }
            }
        }

        return numberOfIslands; // Return total number of islands found
    }
}
