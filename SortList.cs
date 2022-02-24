public class Solution {
    public ListNode SortList(ListNode head) {
        
        if(head == null || head.next == null)
            return head;
        
        ListNode mid = FindMid(head);
        ListNode left = SortList(head);
        ListNode right = SortList(mid);
            
        return MergeLists(left, right);
    }
    
    private ListNode FindMid(ListNode head)
    {
        if(head == null)
            return head;

        ListNode fast = head;
        ListNode slow = head;
        ListNode slowPrev = null;
        
        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slowPrev = slow;
            slow = slow.next;
        }
        
        slowPrev.next = null;
        
        return slow;
    }
    
    private ListNode MergeLists(ListNode l1, ListNode l2)
    {
        if(l1 == null)
            return l2;
        else if(l2 == null)
            return l1;
        
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        
        while(l1 != null && l2 != null)
        {
            if(l1.val <= l2.val)
            {
                curr.next = l1;
                curr = l1;
                l1 = l1.next;
            }
            else
            {
                curr.next = l2;
                curr = l2;
                l2 = l2.next;
            }
        }
        
        curr.next = l1 == null? l2 : l1;
        
        return dummy.next;    
    }
}
