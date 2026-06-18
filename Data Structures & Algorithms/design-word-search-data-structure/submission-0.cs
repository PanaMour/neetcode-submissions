public class WordDictionary {
    TrieNode root;

    public class TrieNode {
        public TrieNode[] children;
        public bool isEndOfWord;

        public TrieNode() {
            children = new TrieNode[26];
            isEndOfWord = false;
        }
    }

    public WordDictionary() {
        root = new TrieNode();
    }

    public void AddWord(string word) {
        TrieNode cur = root;
        foreach (char c in word) {
            int index = c - 'a';
            if (cur.children[index] == null) {
                cur.children[index] = new TrieNode();
            }
            cur = cur.children[index];
        }
        cur.isEndOfWord = true;
    }

    public bool Search(string word) {
        return DFS(word, 0, root);
    }

    private bool DFS(string word, int index, TrieNode node) {
        for (int i = index; i < word.Length; i++) {
            char c = word[i];
            if (c == '.') {
                foreach (TrieNode child in node.children) {
                    if (child != null && DFS(word, i + 1, child)) {
                        return true;
                    }
                }
                return false;
            } else {
                int charIndex = c - 'a';
                if (node.children[charIndex] == null) {
                    return false;
                }
                node = node.children[charIndex];
            }
        }
        return node.isEndOfWord;
    }
}