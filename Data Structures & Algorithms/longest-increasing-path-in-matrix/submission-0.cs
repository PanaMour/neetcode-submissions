public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        int[,] dp = new int[matrix.Length, matrix[0].Length];
        int max = 0;
        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[0].Length; j++) {
                max = Math.Max(max, DFS(i, j, matrix, dp));
            }
        }

        return max;
    }
    int DFS(int i, int j, int[][] matrix, int[,] dp) {
        if (i < 0 || i >= matrix.Length || j < 0 || j >= matrix[0].Length) {
            return 0;
        }

        if (dp[i, j] > 0) {
            return dp[i, j];
        }

        int up = 0, right = 0, down = 0, left = 0;
        if (i + 1 < matrix.Length && matrix[i][j] < matrix[i + 1][j])
            down = DFS(i + 1, j, matrix, dp);
        if (i - 1 >= 0 && matrix[i][j] < matrix[i - 1][j])
            up = DFS(i - 1, j, matrix, dp);
        if (j + 1 < matrix[0].Length && matrix[i][j] < matrix[i][j + 1])
            right = DFS(i, j + 1, matrix, dp);
        if (j - 1 >= 0 && matrix[i][j] < matrix[i][j - 1])
            left = DFS(i, j - 1, matrix, dp);

        int max = Math.Max(up, Math.Max(right, Math.Max(down, left)));
        dp[i, j] = 1 + max;
        return dp[i, j];
    }
}
