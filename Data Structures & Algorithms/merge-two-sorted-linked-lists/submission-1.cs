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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode dummy = new ListNode();
    ListNode merged = dummy;

    while (list1 != null && list2 != null) {
        if (list1.val <= list2.val)
        {
            merged.next = list1;
            list1 = list1.next;
        }
        else if (list1.val > list2.val)
        {
            merged.next = list2;
            list2 = list2.next;
        }
        merged = merged.next;
    }
    if (list1 != null) merged.next = list1;
    else if (list2 != null) merged.next = list2;
    return dummy.next;
}
}