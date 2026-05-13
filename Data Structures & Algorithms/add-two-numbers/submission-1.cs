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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode dummy = new ListNode(); // The anchor for our new list
            ListNode curr = dummy;           // The pointer that builds the list
                int carry = 0;

                    // Keep going if l1 has nodes, OR l2 has nodes, OR we have a leftover carry!
                        while (l1 != null || l2 != null || carry != 0)
                            {
                                    // 1. Get the values (If a list ran out of nodes, treat its value as 0)
                                            int val1 = (l1 != null) ? l1.val : 0;
                                                    int val2 = (l2 != null) ? l2.val : 0;

                                                            // 2. Calculate the total sum for this column
                                                                    int sum = val1 + val2 + carry;

                                                                            // 3. Update the carry for the NEXT loop (e.g., 14 / 10 = 1)
                                                                                    carry = sum / 10;

                                                                                            // 4. Create the new node with the 1s digit (e.g., 14 % 10 = 4)
                                                                                                    curr.next = new ListNode(sum % 10);

                                                                                                            // 5. Move all our pointers forward!
                                                                                                                    curr = curr.next;
                                                                                                                            if (l1 != null) l1 = l1.next;
                                                                                                                                    if (l2 != null) l2 = l2.next;
                                                                                                                                        }

                                                                                                                                            // Return the actual start of the list, skipping the dummy!
                                                                                                                                                return dummy.next;
                                                                                                                                                }
                                                                                                                                                
}
