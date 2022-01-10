/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        // Applying floyds algorithm
        if(head == null) return false; 
        ListNode hare = head; 
        ListNode tortoise = head;
        while(true){
            hare = hare.next;
            tortoise = tortoise.next;
            if(hare == null || hare.next == null){
                return false;
            }
            else{
            hare = hare.next;
            }
            if(hare == tortoise){
                break;
            }
        }
        return true;
    }
}