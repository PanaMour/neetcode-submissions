public class Solution {
    public class TrieNode {
        public TrieNode[] children = new TrieNode[26];
        public string word = null;
    }
    public List<string> FindWords(char[][] board, string[] words) {
        List<string> result = new List<string>();
        TrieNode root = new TrieNode();
        foreach (string w in words) {
            TrieNode curr = root;
            foreach (char c in w) {
                int index = c - 'a';
                if (curr.children[index] == null) {
                    curr.children[index] = new TrieNode();
                }
                curr = curr.children[index];
            }
            curr.word = w;
        }

        for (int r = 0; r < board.Length; r++) {
            for (int c = 0; c < board[0].Length; c++) {
                DFS(board, r, c, root, result);
            }
        }

        return result;
    }

    private void DFS(char[][] board, int r, int c, TrieNode node, List<string> result) {
        if (r < 0 || c < 0 || r >= board.Length || c >= board[0].Length || board[r][c] == '#') {
            return;
        }

        char letter = board[r][c];
        int index = letter - 'a';

        if (node.children[index] == null) {
            return;
        }

        TrieNode nextNode = node.children[index];

        if (nextNode.word != null) {
            result.Add(nextNode.word);
            nextNode.word = null;
        }
        board[r][c] = '#';

        DFS(board, r + 1, c, nextNode, result);  // Down
        DFS(board, r - 1, c, nextNode, result);  // Up
        DFS(board, r, c + 1, nextNode, result);  // Right
        DFS(board, r, c - 1, nextNode, result);  // Left

        board[r][c] = letter;
    }
}
