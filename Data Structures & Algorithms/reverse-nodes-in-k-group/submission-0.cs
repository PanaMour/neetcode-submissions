/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode getKth(ListNode curr, int k) {
        while (curr != null && k > 0) {
            curr = curr.next;
            k -= 1;
        }
        return curr;
    }
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummy = new ListNode(0, head);
        ListNode groupPrev = dummy;

        while (true) {
            var kth = getKth(groupPrev, k);
            if (kth == null)
                break;
            var groupNext = kth.next;
            var prev = kth.next;
            var curr = groupPrev.next;
            ListNode tmp;
            while (curr != groupNext) {
                tmp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tmp;
            }
            tmp = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = tmp;
        }

        return dummy.next;
    }
}
