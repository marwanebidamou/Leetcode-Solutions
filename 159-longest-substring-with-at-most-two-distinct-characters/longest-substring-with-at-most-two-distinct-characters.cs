public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {

        Dictionary<char,int> letters = new Dictionary<char,int>();
        int longestSubLength = 0;
        
        for(int left=0, right=0;right<s.Length; right++)
        {            
            if(!letters.ContainsKey(s[right]))
                letters.Add(s[right], 1);
            else {
                letters[s[right]]+=1;
            }
             
            while(letters.Count()>2){
                letters[s[left]]-=1;
                if(letters[s[left]]==0)
                    letters.Remove(s[left]);
                left++;
            }
            

            longestSubLength = Math.Max(right-left+1, longestSubLength);

        }

        return longestSubLength;

    }
}