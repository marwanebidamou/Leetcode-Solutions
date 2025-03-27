public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        string res = "";

        string modelWord = strs[0];
        int length = modelWord.Length;

        for(int i=0;i<length;i++)
        {
            bool noMatch = false;
            foreach(string word in strs)
            {
                if(word.Length < i+1 || word[i]!=modelWord[i])
                {
                    noMatch = true;
                    break;
                }
            }
            if(noMatch==false){
                res+=modelWord[i];
            } else{
                break;
            }
        }

        return res;
    }
}