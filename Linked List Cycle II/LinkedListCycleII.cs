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
    public ListNode DetectCycle(ListNode head) {
      //Floyds Algorithm
        if(head == null) return null;
     ListNode hare = head;
     ListNode tortoise = head;
     while(true){
         hare = hare.next;
         tortoise = tortoise.next;
         if(hare == null || hare.next == null){
             return null;
         }
         else{
             hare = hare.next;
         }
         if(hare == tortoise){
             break;
         }
     }
    ListNode p1 = head;
    ListNode p2 = tortoise;
    while(p1 != p2){
        p1 = p1.next;
        p2 = p2.next;
    }    
    return p1;
    }
}