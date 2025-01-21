/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {        
        return GuessHelper(1,n);        
    }

    public int GuessHelper(int min, int max)
    {
        int number = min + ((max-min) / 2);
        int guessResult = guess(number);

        if(guessResult == 0)
            return number;
        else if(guessResult == -1)
            return GuessHelper(min, number-1);
        else
            return GuessHelper(number+1, max);
    }
}
