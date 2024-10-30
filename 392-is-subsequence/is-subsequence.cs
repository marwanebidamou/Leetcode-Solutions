public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sPointer=0;
        int tPointer=0;

        while(tPointer<t.Length && sPointer<s.Length){
            
            if(s[sPointer]==t[tPointer])
                sPointer++;

            tPointer++;

            if (sPointer==s.Length)
                return true;
        }

        if (sPointer==s.Length)
            return true;
        return false;
    }
}