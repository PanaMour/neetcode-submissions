public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
{
    int m = matrix.Length;
    int n = matrix[0].Length;
    int l = 0;
    for(int i = 0; i < m; i++)
    {
        if (target <= matrix[i][n - 1])
        {
            while(l <= n)
            {
                int mid = (n + l) / 2;
                if (target < matrix[i][mid])
                {
                    n = mid - 1;
                }
                else if( target > matrix[i][mid])
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
    return false;
}
}
