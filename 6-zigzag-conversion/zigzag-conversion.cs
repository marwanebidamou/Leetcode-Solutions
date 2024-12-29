public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || s.Length <= numRows)
            return s;

        // Use StringBuilder array for each row
        StringBuilder[] rows = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++) {
            rows[i] = new StringBuilder();
        }

        int index = 0;
        int direction = 1; // 1 for down, -1 for up

        // Traverse the string and add characters to the appropriate row
        foreach (char c in s) {
            rows[index].Append(c);
            
            // Change direction when reaching the top or bottom row
            if (index == 0) direction = 1;
            if (index == numRows - 1) direction = -1;

            index += direction;
        }

        // Combine all rows into a single result
        StringBuilder result = new StringBuilder();
        foreach (var row in rows) {
            result.Append(row);
        }

        return result.ToString();
    }
}
