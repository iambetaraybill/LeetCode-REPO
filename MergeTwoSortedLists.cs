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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode head = new ListNode(0);
            ListNode start = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    start.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    start.next = l2;
                    l2 = l2.next;
                }

                start = start.next;
            }

            if (l1 != null)
            {
                start.next = l1;
            }

            if (l2 != null)
            {
                start.next = l2;
            }

            return head.next;
    }
}
