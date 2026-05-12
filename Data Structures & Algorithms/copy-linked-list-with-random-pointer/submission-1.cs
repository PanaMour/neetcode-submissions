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
                var dic = new Dictionary<int, (Node newnode,int random)>();
    
    int count = 0;
    Node dum = head;
    while (dum != null)
    {
        Node dummy = head;
        int i = 0;
        while (dummy != dum.random)
        {
            dummy = dummy.next;
            i++;
        }
        dic[count] = (new Node(dum.val), i);

        count++;
        dum = dum.next;
    }
    for (int i = 0; i < count; i++)
    {
        if(i+1 == count)
            dic[i].newnode.next = null;
        else
            dic[i].newnode.next = dic[i + 1].newnode;
        if (dic[i].random < count)
        {
            
            dic[i].newnode.random = dic[dic[i].random].newnode;
            Console.WriteLine(dic[i].random + "  " + dic[i].newnode.random.val);
        }
        else
        {
            dic[i].newnode.random = null;
        }
    }

    return dic[0].newnode;
}
}
