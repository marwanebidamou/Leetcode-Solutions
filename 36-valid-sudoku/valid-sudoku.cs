public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        int n = board.Length;
        // Arrays of HashSet to track numbers seen in each row, column, and 3x3 box
        HashSet<char>[] rows = new HashSet<char>[n];
        HashSet<char>[] cols = new HashSet<char>[n];
        HashSet<char>[] boxes = new HashSet<char>[n];

        // Initialize HashSet for each row, column, and box
        for (int i = 0; i < n; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        // Iterate through every cell in the board
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                char num = board[i][j];

                if (num == '.') continue;

                // Validate row
                if (!rows[i].Add(num)) return false;

                // Validate column
                if (!cols[j].Add(num)) return false;

                // Validate 3x3 box
                // Calculate the index of the box that the current cell (i, j) belongs to
                int boxIndex = (i / 3) * 3 + j / 3;
                if (!boxes[boxIndex].Add(num)) return false;
            }
        }

        return true;
    }
}
