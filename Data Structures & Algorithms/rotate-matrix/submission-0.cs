public class Solution {
    public void Rotate(int[][] matrix) {
        for (int i = 0; i < matrix.Length; i++) {
            for (int j = i; j < matrix[0].Length; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[0].Length / 2; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][matrix[0].Length - j - 1];
                matrix[i][matrix[0].Length - j - 1] = temp;
            }
        }
    }
}
