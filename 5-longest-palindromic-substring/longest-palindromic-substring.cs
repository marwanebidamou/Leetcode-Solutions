public class Solution {
    public string LongestPalindrome(string s) {
        
        string res="";

        int l=0, r=0;

        for(int i=0;i<s.Length;i++)
        {
            l = i;
            r = i;

            while(l>=0 && r<s.Length && s[l] == s[r])
            {
                var str = s[l..(r+1)];
                if(str.Length > res.Length)
                {
                    res = str;
                }
                l--;
                r++;            
            }

            l = i;
            r = i+1;

            while(l>=0 && r<s.Length && s[l] == s[r])
            {
                var str = s[l..(r+1)];
                if(str.Length > res.Length)
                {
                    res = str;
                }
                l--;
                r++;            
            }
        }

        return res;
    }
}