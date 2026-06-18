public class PrefixTree
{
    TrieNode root;
    public class TrieNode
    {
        public TrieNode[] children;
        public bool isEndOfWord;
        public TrieNode()
        {
            children = new TrieNode[26];
            isEndOfWord = false;
        }        
    }
    public PrefixTree()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode cur = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (cur.children[index] == null)
            {
                cur.children[index] = new TrieNode();
            }
            cur = cur.children[index];
        }
        cur.isEndOfWord = true;
    }

    public bool Search(string word)
    {
        TrieNode cur = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (cur.children[index] == null)
            {
                return false;
            }
            cur = cur.children[index];
        }
        return cur.isEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        TrieNode cur = root;
        foreach (char c in prefix)
        {
            int index = c - 'a';
            if (cur.children[index] == null)
            {
                return false;
            }
            cur = cur.children[index];
        }
        return true;
    }
}