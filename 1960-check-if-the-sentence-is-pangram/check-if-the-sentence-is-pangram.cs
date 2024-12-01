public class Solution {
    public bool CheckIfPangram(string sentence) {
        
        HashSet<char> chars = new HashSet<char>();

        for(int i=0;i<sentence.Length;i++)
        {
            chars.Add(sentence[i]);
        }

        return chars.Count()==26;

    }
}