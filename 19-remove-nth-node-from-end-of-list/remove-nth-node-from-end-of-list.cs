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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        if(head.next == null)
            return null;

        // Create a dummy node that points to the head of the list.
        // This helps handle edge cases, like removing the first node.
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        // Initialize two pointers, both starting at the dummy node.
        ListNode slow = dummy;
        ListNode fast = dummy;

        // Move the 'fast' pointer n steps ahead in the list.
        // This creates a gap of 'n' nodes between 'fast' and 'slow'.
        while(n>0){
            fast = fast.next;
            n--;
        }

        // Move both 'slow' and 'fast' pointers one step at a time 
        // until 'fast' reaches the last node. This positions 'slow'
        // just before the node that needs to be removed.
        while(fast?.next!=null){
            slow = slow.next;
            fast = fast.next;
        }

         // Remove the nth node from the end by skipping it.
        // 'slow.next' is the node to be removed, so update
        // 'slow.next' to point to the node after it.
        slow.next = slow.next.next;

        // Return the updated list, starting from the original head.
        // The dummy node helps manage cases where the head is removed.
        return dummy.next;
    }

 
}