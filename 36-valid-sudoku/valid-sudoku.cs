public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        int n=board.Length;


        for(int i=0;i<n;i++)
        {
            HashSet<char> row = new HashSet<char>();
            HashSet<char> col = new HashSet<char>();

            for(int j=0;j<n;j++)
            {
                Console.WriteLine(" row "+board[i][j]+" col "+board[j][i]);
                if(board[i][j]!= '.' && !row.Add(board[i][j]))
                    return false;
                
                if(board[j][i]!= '.' && !col.Add(board[j][i]))
                    return false;
            }
        }

        int numberOfBoxPerLine = n/3;


        for(int i=0;i<n;i+=3)
        {
            for(int j=0;j<n;j+=3)
            {
                HashSet<char> vals = new HashSet<char>();
                for(int row=0;row<3;row++)
                {
                    for(int col=0;col<3;col++)
                    {
                        var cell = board[i+row][j+col];
                        if(cell!='.' && !vals.Add(cell))
                            return false;
                    }
                }                
            }
        }
        
        return true;

    }   
}