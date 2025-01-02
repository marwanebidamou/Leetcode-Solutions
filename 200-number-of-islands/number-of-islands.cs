public class Solution {
    private int m; // Number of rows in the grid
    private int n; // Number of columns in the grid
    private bool[,] seen; // To keep track of visited cells

    public int NumIslands(char[][] grid) {
        int ans = 0; // Initialize the number of islands
        m = grid.Length; // Total rows
        n = grid[0].Length; // Total columns
        seen = new bool[m, n]; // Initialize visited tracking array

        // Iterate through every cell in the grid
        for (int row = 0; row < m; row++) {
            for (int col = 0; col < n; col++) {
                // If the cell is part of land ('1') and hasn't been visited yet
                if (grid[row][col] == '1' && !seen[row, col]) {
                    ans++; // Start a new island
                    seen[row, col] = true; // Mark the cell as visited
                    Dfs(row, col, grid); // Perform DFS to mark all connected land
                }
            }
        }

        return ans; // Return the total number of islands found
    }

    // Check if the given cell is valid and part of land ('1')
    private bool IsValid(int row, int col, char[][] grid) {
        // Check bounds and ensure the cell is part of land ('1')
        return row >= 0 && row < m && col >= 0 && col < n && grid[row][col] == '1';
    }

    // Depth-First Search to mark all connected land cells
    private void Dfs(int row, int col, char[][] grid) {
        // Explore right
        if (IsValid(row, col + 1, grid) && !seen[row, col + 1]) {
            seen[row, col + 1] = true;
            Dfs(row, col + 1, grid);
        }

        // Explore down
        if (IsValid(row + 1, col, grid) && !seen[row + 1, col]) {
            seen[row + 1, col] = true;
            Dfs(row + 1, col, grid);
        }

        // Explore left
        if (IsValid(row, col - 1, grid) && !seen[row, col - 1]) {
            seen[row, col - 1] = true;
            Dfs(row, col - 1, grid);
        }

        // Explore up
        if (IsValid(row - 1, col, grid) && !seen[row - 1, col]) {
            seen[row - 1, col] = true;
            Dfs(row - 1, col, grid);
        }
    }
}
