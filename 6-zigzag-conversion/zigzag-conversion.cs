public class Solution {
    public string Convert(string s, int numRows) {
        if(s.Length==1 || numRows ==1)
            return s;

            
        List<char>[] builder = new List<char>[numRows];
        for(int i=0;i<numRows;i++)
        {
            builder[i] = new List<char>();
        }
        int index=0;
        bool fromTopToBottom = true;
        for(int i=0;i<s.Length;i++)
        {

            builder[index].Add(s[i]);

            int nextIndex = fromTopToBottom?index+1:index-1;

            if(nextIndex==numRows)
            {
                index=index-1;
                fromTopToBottom=false;
            }
            else if(nextIndex==-1)
            {
                index=index+1;
                fromTopToBottom = true;
            }
            else
            {
                index=nextIndex;
            }
        }


        StringBuilder result = new StringBuilder();
        for(int i=0;i<numRows;i++)
        {
            string line = new String(builder[i].ToArray());
            Console.WriteLine(line);
            result.Append(line);
        }
        return result.ToString();
    }
}