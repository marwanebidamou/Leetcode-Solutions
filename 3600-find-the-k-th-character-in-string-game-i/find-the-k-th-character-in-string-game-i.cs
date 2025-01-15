public class Solution {
    public char KthCharacter(int k) {
        
        StringBuilder builder = new StringBuilder();
        builder.Append('a');
        while(builder.Length<k)
        {
            char[] old = builder.ToString().ToCharArray();
            for(int i=0;i<old.Length;i++)
            {
                if(old[i]=='z')
                    old[i] = 'a';
                else
                    old[i] = (char)(((int)old[i])+1);
            }
            builder.Append(old);
        }


        return builder.ToString()[k-1];
    }
}