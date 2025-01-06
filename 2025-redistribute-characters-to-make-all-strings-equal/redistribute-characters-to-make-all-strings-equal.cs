public class Solution {
    public bool MakeEqual(string[] words) {
        
        Dictionary<char,int> map = new Dictionary<char,int>();

        foreach(string word in words)
        {
            foreach(char character in word)
            {
                map[character] = map.GetValueOrDefault(character) + 1;
            }
        }

        int n = words.Length;
        foreach(var characterCount in map.Values)
        {
            if(characterCount % n != 0)
                return false;
        }

        return true;
    }
}