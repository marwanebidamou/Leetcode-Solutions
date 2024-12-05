public class Solution {
    public bool AreOccurrencesEqual(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i=0;i<s.Length;i++)
        {
            if(dict.ContainsKey(s[i]))
            {
                dict[s[i]]++;
            }
            else
            {
                dict[s[i]]=0;
            }
        }

        int nbOccurences = dict[s[0]];
        foreach(var item in dict)
        {
            if(item.Value!=nbOccurences)
                return false;
        }
        return true;
    }
}