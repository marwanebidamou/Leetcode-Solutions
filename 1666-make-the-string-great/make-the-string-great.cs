public class Solution {
    public string MakeGood(string s) {
        if(s.Length==0)
            return s;

        Stack<char> chars = new Stack<char>();
        
        foreach(char character in s){
            if(chars.Count == 0)
                chars.Push(character);
            else if(chars.Peek() == character)
                chars.Push(character);
            else if(Char.ToLower(chars.Peek()) == Char.ToLower(character))
                chars.Pop();
            else 
                chars.Push(character);
        }

        int charsCount = chars.Count;
        char[] result = new char[charsCount];
        for(int i=1;i<=charsCount;i++)
        {
            result[charsCount-i] = chars.Pop();
        }
        return new string(result);
    }
}