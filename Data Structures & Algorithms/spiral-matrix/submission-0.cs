public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;
        List<int> result = new List<int>();
        while (left <= right && top <= bottom) {
            for (int i = left; i <= right; i++) {
                result.Add(matrix[top][i]);
            }
            top++;

            for (int i = top; i <= bottom; i++) {
                result.Add(matrix[i][right]);
            }
            right--;

            if (left > right || top > bottom)
                break;
            for (int i = right; i >= left; i--) {
                result.Add(matrix[bottom][i]);
            }
            bottom--;
            for (int i = bottom; i >= top; i--) {
                result.Add(matrix[i][left]);
            }
            left++;
        }

        return result;
    }
}
