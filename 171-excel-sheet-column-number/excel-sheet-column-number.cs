public class Solution {
    public int TitleToNumber(string columnTitle) {
        int result = 0;

        foreach (char c in columnTitle) {
            int value = c - 'A' + 1; // Map 'A' to 1, 'B' to 2, ..., 'Z' to 26
            result = result * 26 + value; // Update result for each character
        }

        return result;
    }
}
