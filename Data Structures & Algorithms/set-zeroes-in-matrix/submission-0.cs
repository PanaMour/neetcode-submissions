public class Solution {
    public void SetZeroes(int[][] matrix) {
        HashSet<int> rows = new HashSet<int>();
        HashSet<int> columns = new HashSet<int>();
        
        for(int i=0;i<matrix.Length;i++){
            for(int j=0;j<matrix[0].Length;j++){
                if(matrix[i][j] == 0){
                    rows.Add(i);
                    columns.Add(j);
                }
            }
        }

        for(int i=0;i<matrix.Length;i++){
            for(int j=0;j<matrix[0].Length;j++){
                if(rows.Contains(i)){
                    matrix[i][j] = 0;
                }
                if(columns.Contains(j)){
                    matrix[i][j] = 0;
                }
            }
        }
    }
}
