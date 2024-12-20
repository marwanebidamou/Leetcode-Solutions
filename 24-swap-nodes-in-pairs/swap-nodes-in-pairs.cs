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
    public ListNode SwapPairs(ListNode head) {
        if(head?.next == null)
            return head;

        
        // Dummy node to simplify edge cases
        var dummy = new ListNode(0, head);
        var prev = dummy;

        while (prev.next != null && prev.next.next != null) {
            var node1 = prev.next;
            var node2 = node1.next;

            // Swap the pair
            node1.next = node2.next;
            node2.next = node1;
            prev.next = node2;

            // Move prev pointer to the next pair
            prev = node1;
        }

        return dummy.next;
    }
}