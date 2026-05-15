public class LRUCache
{
    class Node
    {
        public int key;
        public int val;
        public Node prev;
        public Node next;
        public Node(int k, int v) { key = k; val = v; }
    }
    private int capacity;
    private Dictionary<int, Node> cache;
    private Node left;
    private Node right;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        this.cache = new Dictionary<int, Node>();
        this.left = new Node(0, 0);
        this.right = new Node(0, 0);
        this.left.next = this.right;
        this.right.prev = this.left;
    }

    private void Remove(Node node)
    {
        Node prevNode = node.prev;
        Node nxtNode = node.next;

        prevNode.next = nxtNode;
        nxtNode.prev = prevNode;
    }

    private void Insert(Node node)
    {
        Node prevNode = this.right.prev;
        Node nxtNode = this.right;

        prevNode.next = node;
        nxtNode.prev = node;

        node.prev = prevNode;
        node.next = nxtNode;
    }

    public int Get(int key)
    {
        if (cache.ContainsKey(key))
        {
            Remove(cache[key]);
            Insert(cache[key]);
            return cache[key].val;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
        {
            Remove(cache[key]);
        }
        cache[key] = new Node(key, value);
        Insert(cache[key]);

        if(cache.Count > capacity)
        {
            var lru = left.next;
            Remove(lru);
            cache.Remove(lru.key);
        }
    }
}
