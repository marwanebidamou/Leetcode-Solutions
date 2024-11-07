public class Solution {
    public int StrStr(string haystack, string needle) {
        
        if (haystack == needle)
            return 0;

        for(int i=0;i<=haystack.Length-needle.Length;i++){
            Console.WriteLine($"i: {i}");
            if(haystack.Substring(i, needle.Length)==needle)
                return i;
        }
        return -1;
    }
}