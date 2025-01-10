public class Solution {
    public int MaxVowels(string s, int k) {
        // Handle edge cases: empty string or invalid window size
        if (string.IsNullOrEmpty(s) || k == 0) return 0;

        // Initialize pointers for the sliding window
        int left = 0, right = 0;

        // Variable to track the maximum number of vowels in any window of size k
        int maxCount = 0;

        // Variable to keep track of the current count of vowels in the current window
        int count = 0;

        // Iterate through the string with the right pointer
        while (right < s.Length) {
            // Add to the count if the current character at 'right' is a vowel
            count += IsVowel(s[right]) ? 1 : 0;

            // If the window size exceeds k, shrink the window from the left
            if (right - left + 1 > k) {
                // Subtract the vowel count if the character at 'left' is a vowel
                count -= IsVowel(s[left]) ? 1 : 0;

                // Move the left pointer to reduce the window size
                left++;
            }

            // Update the maximum count of vowels found so far
            maxCount = Math.Max(maxCount, count);

            // Expand the window by moving the right pointer
            right++;
        }

        // Return the maximum number of vowels found in any substring of size k
        return maxCount;
    }

    // Define a HashSet to store vowels for quick lookup
    private static readonly HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

    // Helper function to check if a given character is a vowel
    // Converts the character to lowercase to handle uppercase input gracefully
    private bool IsVowel(char character) => Vowels.Contains(char.ToLower(character));
}
