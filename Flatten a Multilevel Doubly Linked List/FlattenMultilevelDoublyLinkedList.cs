/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
       if (head == null) return head;

  Node currentNode = head;
  while (currentNode != null) {
    if (currentNode.child == null) {
      currentNode = currentNode.next;
    } else {
      Node tail = currentNode.child;
      while (tail.next != null) {
        tail = tail.next;
      }

      tail.next = currentNode.next;
      if (tail.next != null) {
        tail.next.prev = tail;
      }

      currentNode.next = currentNode.child;
      currentNode.next.prev = currentNode;
      currentNode.child = null;
    }
  }

  return head; 
    }
}