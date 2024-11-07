public class Solution {
    public string CountAndSay(int n) {
        if (n==1)
            return "1";

        string val = "1";
        for(int i=2;i<=n;i++){
            val = countHelper(val);
        }

        return val;
    }

    private string countHelper(string input){
        string output="";

        if (input.Length==0)
            return "";

        char previousChar=input[0];
        int countChar = 1;
        int index=1;            

        while(index<input.Length){
    
            if (input[index]==previousChar)
            {
                countChar++;               
            }
            else{
                output+=$"{countChar}{previousChar}";
                previousChar=input[index];
                countChar=1;
            }
            index++;
        }

        output+=$"{countChar}{previousChar}";

        return output;
    }

    
}