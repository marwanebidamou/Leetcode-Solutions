public class Solution {
    public bool CloseStrings(string word1, string word2) {
        // If the strings are of different lengths, they cannot be "close".
        if (word1.Length != word2.Length)
            return false;

        // Dictionaries to count the frequency of each character in both strings.
        Dictionary<char, int> map1 = new Dictionary<char, int>();
        Dictionary<char, int> map2 = new Dictionary<char, int>();

        // Populate the frequency dictionaries for both strings.
        for (int i = 0; i < word1.Length; i++) {
            // Increment the count for the character in word1.
            map1[word1[i]] = map1.GetValueOrDefault(word1[i]) + 1;
            // Increment the count for the character in word2.
            map2[word2[i]] = map2.GetValueOrDefault(word2[i]) + 1;
        }

        // If the number of unique characters in the two strings is different, they cannot be "close".
        if (map1.Count != map2.Count)
            return false;

        // Check if the two strings contain the same set of unique characters.
        if (!map1.Keys.OrderBy(x => x).SequenceEqual(map2.Keys.OrderBy(x => x)))
            return false;

        // Check if the frequency distributions of the characters are the same (order doesn't matter).
        if (!map1.Values.OrderBy(x => x).SequenceEqual(map2.Values.OrderBy(x => x)))
            return false;

        //All good :)    
        return true;

    }
}