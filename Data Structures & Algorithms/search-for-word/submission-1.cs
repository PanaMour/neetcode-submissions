public class Solution {
    public bool Exist(char[][] board, string word) {
        for (int r = 0; r < board.Length; r++) {
            for (int c = 0; c < board[0].Length; c++) {
                if (board[r][c] == word[0]) {
                    if (DFS(board, word, r, c, 0)) {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private bool DFS(char[][] board, string word, int r, int c, int i) {
        if (i == word.Length)
            return true;
        if (r < 0 || c < 0 || r >= board.Length || c >= board[0].Length)
            return false;
        if (board[r][c] != word[i])
            return false;
        char temp = board[r][c];
        board[r][c] = '#';
        bool found = DFS(board, word, r + 1, c, i + 1) || DFS(board, word, r - 1, c, i + 1) ||
                     DFS(board, word, r, c + 1, i + 1) || DFS(board, word, r, c - 1, i + 1);
        board[r][c] = temp;
        return found;
    }
}
