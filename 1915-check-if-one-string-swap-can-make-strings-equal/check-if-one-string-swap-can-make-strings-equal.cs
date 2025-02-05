public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if (s1 == s2) return true; // Already equal

        List<int> diffIndices = new List<int>();

        // Find indices where s1 and s2 differ
        for (int i = 0; i < s1.Length; i++) {
            if (s1[i] != s2[i]) {
                diffIndices.Add(i);
                if (diffIndices.Count > 2) return false; // More than 2 differences => can't be one swap
            }
        }

        // There must be exactly 2 differences
        if (diffIndices.Count != 2) return false;

        // Check if swapping these two indices makes s1 equal to s2
        int i1 = diffIndices[0], i2 = diffIndices[1];
        return s1[i1] == s2[i2] && s1[i2] == s2[i1];
    }
}
