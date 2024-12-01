public class Solution {
    public char RepeatedCharacter(string s) {
        HashSet<int> chars = new HashSet<int>();
        for(int i=0;i<s.Length;i++)
        {
            if(!chars.Add(s[i]))
                return s[i];
        }
        return ' ';
    }
}