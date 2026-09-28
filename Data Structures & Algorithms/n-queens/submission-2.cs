public class Solution {
    public List<List<string>> SolveNQueens(int n) {
        List<List<string>> result = new List<List<string>>();
        char[][] board = new char [n][];
        for (int i = 0; i < n; i++) {
            board[i] = new char[n];
            for (int j = 0; j < n; j++) {
                board[i][j] = '.';
            }
        }
        HashSet<int> cols = new HashSet<int>();
        HashSet<int> negDiag = new HashSet<int>();
        HashSet<int> posDiag = new HashSet<int>();
        Backtrack(0, n, board, cols, posDiag, negDiag, result);
        return result;
    }
    private void Backtrack(int r, int n, char[][] board, HashSet<int> cols, HashSet<int> posDiag,
                           HashSet<int> negDiag, List<List<string>> result) {
        if (r == n) {
            List<string> currentBoard = new List<string>();
            foreach (char[] row in board) {
                currentBoard.Add(new string(row));
            }
            result.Add(currentBoard);
            return;
        }
        for (int c = 0; c < n; c++) {
            if (cols.Contains(c) || posDiag.Contains(r + c) || negDiag.Contains(r - c))
                continue;
            cols.Add(c);
            posDiag.Add(r + c);
            negDiag.Add(r - c);
            board[r][c] = 'Q';
            Backtrack(r + 1, n, board, cols, posDiag, negDiag, result);
            cols.Remove(c);
            posDiag.Remove(r + c);
            negDiag.Remove(r - c);
            board[r][c] = '.';
        }
    }
}
