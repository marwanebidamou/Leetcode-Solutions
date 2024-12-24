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
        if (head == null || head.next == null || left == right) {
            return head;
        }

        // Create a dummy node to handle edge cases more easily
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;

        // Move `prev` to the node just before the `left` position
        for (int i = 1; i < left; i++) {
            prev = prev.next;
        }

        // Start reversing nodes between `left` and `right`
        ListNode current = prev.next;
        ListNode next = null;
        ListNode reverseTail = current;

        for (int i = 0; i < right - left + 1; i++) {
            next = current.next;
            current.next = prev.next;
            prev.next = current;
            current = next;
        }

        // Connect the reversed portion back to the rest of the list
        reverseTail.next = current;

        return dummy.next;
    }
}
