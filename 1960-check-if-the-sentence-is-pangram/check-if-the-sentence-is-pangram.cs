public class Solution {
    public bool CheckIfPangram(string sentence) {
        
        HashSet<char> chars = new HashSet<char>();

        for(int i=0;i<sentence.Length;i++)
        {
            chars.Add(sentence[i]);

            if(chars.Count()==26)
                return true;
        }

        return false;

    }
}