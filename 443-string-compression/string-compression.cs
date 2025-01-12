public class Solution {
    public int Compress(char[] chars) {
        
        int writeIndex = 0;

        int index = 1;
        char lastChar=chars[0];
        int lastCharCount = 1;
        while(index<chars.Length)
        {
            if(chars[index]==lastChar) {
                lastCharCount++;
            } else {
                if(lastCharCount==1) {
                    chars[writeIndex++] = lastChar;
                } else {
                    chars[writeIndex++] = lastChar;
                    string wholeNumber = lastCharCount.ToString();
                    foreach(char num in wholeNumber) {
                        chars[writeIndex++] = num;
                    }
                }
                lastCharCount=1;
                lastChar=chars[index];
            }
            index++;
        }

        //handle last character
        if(lastCharCount==1) {
            chars[writeIndex++] = lastChar;
        } else {
            chars[writeIndex++] = lastChar;
            string wholeNumber = lastCharCount.ToString();
            foreach(char num in wholeNumber) {
                chars[writeIndex++] = num;
            }
        }

        return writeIndex;
    }
}