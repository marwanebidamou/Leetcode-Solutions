public class Solution {
    public string ReverseWords(string s) {
        
        int left=0;
        int right=0;

        char[] strArray = s.ToCharArray();

        while(right<strArray.Length-1)
        {
            while(right<strArray.Length-1 && strArray[right+1]!=' ')
                 right++;

            int currRight = right;

            Console.WriteLine("Left = "+left+" - right = "+right);
            

            while(left<currRight)
            {
                char tmp=strArray[left];
                strArray[left]=strArray[currRight];
                strArray[currRight] = tmp;
                left++;
                currRight--;
            }

            left=right+2;
            right=right+2;
        }

        return new string(strArray);
    }
}