public class Solution {
    public void Solve(char[][] board) {
        int rows = board.Length;
        int cols = board[0].Length;
        for (int r = 0; r < rows; r++) {
            DFS(r, 0, board);
            DFS(r, cols - 1, board);
        }
        for (int c = 0; c < cols; c++) {
            DFS(0, c, board);
            DFS(rows - 1, c, board);
        }
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (board[i][j] == 'O') {
                    board[i][j] = 'X';
                } else if (board[i][j] == 'T') {
                    board[i][j] = 'O';
                }
            }
        }
    }
    private void DFS(int r, int c, char[][] board) {
        if (r < 0 || c < 0 || r >= board.Length || c >= board[0].Length || board[r][c] != 'O') {
            return;
        }
        board[r][c] = 'T';
        DFS(r + 1, c, board);
        DFS(r - 1, c, board);
        DFS(r, c + 1, board);
        DFS(r, c - 1, board);
        return;
    }
}
