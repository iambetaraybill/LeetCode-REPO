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

 /// Complexity O(m+n)
 // O(n) will have to see later////////////////////
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode res = null;
        ListNode prev = null;
        ListNode temp = null;
        int carry = 0, sum;
 
        while (l1 != null || l2 != null) {
            
            sum = carry + (l1 != null ? l1.val : 0)
                  + (l2 != null ? l2.val : 0);
            carry = (sum >= 10) ? 1 : 0;
            sum = sum % 10;
            temp = new ListNode(sum);
 
            if (res == null) {
                res = temp;
            }
            else {
                prev.next = temp;
            }
            prev = temp;
            if (l1 != null) {
                l1 = l1.next;
            }
            if (l2 != null) {
                l2 = l2.next;
            }
        }
 
        if (carry > 0) {
            temp.next = new ListNode(carry);
        }
        return res;
    }
}