/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) return head;
var map = new Dictionary<Node,Node>();
Node curr = head;
while(curr != null)
{
    map[curr] = new Node(curr.val);
    curr = curr.next;
}
curr = head;
while(curr != null)
{
    Node clone = map[curr];
    if (curr.next != null)
    {
        clone.next = map[curr.next];
    }

    if(curr.random != null)
    {
        clone.random = map[curr.random];
    }
    curr = curr.next;
}

return map[head];
}
}
