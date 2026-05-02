public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
{
    int m = matrix.Length;
    int n = matrix[0].Length;
    int l = 0;
    int r = (m * n) - 1;

    while(l <= r) 
    { 
        int mid = l + (r-l) / 2;
        int row = mid / n;
        int col = mid % n;
        int midValue = matrix[row][col];
        if(midValue > target)
        {
            r = mid - 1;
        }else if(midValue < target)
        {
            l = mid + 1;
        }
        else
        {
            return true;
        }
    }
    return false;
}
}
