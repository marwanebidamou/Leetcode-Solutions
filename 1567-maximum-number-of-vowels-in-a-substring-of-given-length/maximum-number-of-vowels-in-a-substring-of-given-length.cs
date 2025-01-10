public class Solution {
    public int MaxVowels(string s, int k) {
        
        int left = 0;
        int right = 0;

        int maxCount = 0;
        int count = 0;

        while(right<s.Length)
        {
            int currentWindowSize = right-left+1;
            if(currentWindowSize > k)
            {
                count-=IsVowel(s[left]) ? 1 : 0;
                left++;
            }
            else
            {
                count+=IsVowel(s[right]) ? 1 : 0;
                right++;
            }


            maxCount = Math.Max(maxCount, count);
        }

        return maxCount;
    }

    private bool IsVowel(char character)
    {
        return character=='a' || character=='e' || character=='i' || character=='o' || character=='u';
    }
}