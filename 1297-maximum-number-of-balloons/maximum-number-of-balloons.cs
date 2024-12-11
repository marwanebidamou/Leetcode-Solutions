public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char,int> map = new Dictionary<char,int>();

        for(int i=0;i<text.Length;i++)
        {
            if(text[i]=='b' || text[i]=='a'  || text[i]=='l' || text[i]=='o' || text[i]=='n')
            {
                map[text[i]]=map.GetValueOrDefault(text[i])+1;
            }
        }

        if(map.Count()<5)//5 is the count of uniaue chars in 'balloon'
        {
            return 0;
        }

        map['l']=map['l']/2;
        map['o']=map['o']/2;

        int minOccurenceOfLetter = text.Length;
        foreach(var element in map)
        {
            minOccurenceOfLetter = Math.Min(element.Value,minOccurenceOfLetter); 
        }

        return minOccurenceOfLetter;

    }
}