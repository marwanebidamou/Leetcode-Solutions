public class Solution {
    public string ReverseOnlyLetters(string s) {
        
        HashSet<char> chars = new HashSet<char>
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 
            'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 
            'y', 'z'
        };
        char[] sArray = s.ToArray();
        int left = 0;
        int right = s.Length - 1;

        while(left<right)
        {
            while(left<s.Length-1 && !chars.Contains(char.ToLower(sArray[left])))
                left++;
            
            while(right>0 && !chars.Contains(char.ToLower(sArray[right])))
                right--;
            
            if(left>=right)
                break;

            char tmp=sArray[left];
            sArray[left]=sArray[right];
            sArray[right]=tmp;
            left++;
            right--;
        }

        return new string(sArray);
    }
}