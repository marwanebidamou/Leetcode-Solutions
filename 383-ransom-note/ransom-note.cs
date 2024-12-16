public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> magazineLetters = new Dictionary<char,int>();
        for(int i=0;i<magazine.Length;i++)
        {
            magazineLetters[magazine[i]] = magazineLetters.GetValueOrDefault(magazine[i]) + 1;
        }

        for(int i=0;i<ransomNote.Length;i++)
        {
            if(magazineLetters.GetValueOrDefault(ransomNote[i])>0)
                magazineLetters[ransomNote[i]]--;
            else
                return false;
        }
        return true;
    }
}