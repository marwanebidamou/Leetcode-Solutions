public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        

        int line=0;
        while(line<matrix.Length-1 && matrix[line+1][0]<=target)
            line++;

        int left = 0;
        int right = matrix[0].Length-1;


        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            if(matrix[line][mid] == target)
                return true;
            else if(matrix[line][mid] > target)
                right = mid - 1;
            else
                left = mid + 1;

        }

        return false;
    }
}