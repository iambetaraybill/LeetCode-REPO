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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        int currentPosition = 1;
        ListNode current = head;
        ListNode start = head;
        while(currentPosition < left){
            start = current;
            current = current.next;
            currentPosition++; 
        }
        ListNode newList = null;
        ListNode tail = current;
        while(currentPosition >= left && currentPosition <= right){
            ListNode next = current.next;
            current.next = newList;
            newList = current;
            current = next;
            currentPosition++;
        }
        start.next = newList;
        tail.next = current;
        if(left>1){
            return head;
        }else{
            return newList;
        }
        
    }
}