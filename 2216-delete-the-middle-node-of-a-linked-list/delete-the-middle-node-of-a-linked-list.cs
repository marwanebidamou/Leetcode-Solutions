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
    public ListNode DeleteMiddle(ListNode head) {
        // Edge case: If the list has only one node, return null (no nodes remain after deletion).
        if(head.next == null)
            return null;

        // Initialize pointers:
        // - 'slow' will traverse the list one step at a time.
        // - 'fast' will traverse the list two steps at a time.
        // - 'prev' will track the node before 'slow', so we can modify the list when deleting the middle node.
        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = null;

        // Move 'slow' and 'fast' pointers through the list:
        // - 'slow' will end up at the middle node when 'fast' reaches the end.
        // - 'prev' will point to the node just before 'slow'.
        while(fast?.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }


        // Remove the middle node by skipping it:
        // - Update 'prev.next' to point to the node after 'slow'.
        // - This effectively deletes the node that 'slow' points to from the list.
        prev.next = slow.next;

        // Return the head of the modified list.
        return head;
    }
}