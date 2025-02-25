public class Solution {
    public int Maximum69Number (int num) {
        
        char[] str = num.ToString().ToArray();
        
        int index = 0;
        while(index<str.Length)
        {
            if(str[index]=='6')
            {
                str[index]='9';
                break;
            }
            index++;
        }


       

        return int.Parse(new string(str));
    }
}