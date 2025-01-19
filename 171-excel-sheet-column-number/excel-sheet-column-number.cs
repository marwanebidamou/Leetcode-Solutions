public class Solution {
    public int TitleToNumber(string columnTitle) {
        int result = 0;

        foreach (char c in columnTitle) {
            int value = c - 'A' + 1;
            result = result * 26 + value;
        }

        return result;
    }
}
