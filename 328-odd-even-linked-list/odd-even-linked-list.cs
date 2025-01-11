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
    public ListNode OddEvenList(ListNode head) {
        if(head?.next?.next == null)
            return head;
        
        // Initialize pointers for odd and even nodes.
        ListNode oddNode = head; // Pointer to the current odd-indexed node.
        ListNode evenNode = head.next; // Pointer to the current even-indexed node.
        ListNode evenHead = evenNode; // Store the head of the even nodes to connect later.

        while (oddNode?.next != null && evenNode?.next != null) {
            // Connect the current odd node to the next odd node.
            oddNode.next = oddNode.next.next;
            // Connect the current even node to the next even node.
            evenNode.next = evenNode.next.next;
            
            // Move the odd and even pointers to their next respective nodes.
            oddNode = oddNode.next;
            evenNode = evenNode.next;
        }

        // Connect the last odd node to the head of the even list.
        oddNode.next = evenHead;

        return head;
        
    }
}