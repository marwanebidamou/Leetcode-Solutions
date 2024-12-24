/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;         // The value of the current node.
 *     public ListNode next;   // Pointer to the next node in the list.
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int PairSum(ListNode head) {
        // Initialize two pointers, slow and fast, both starting at the head of the list.
        ListNode slow = head;
        ListNode fast = head;

        // Step 1: Find the middle of the linked list using slow and fast pointers.
        // Fast pointer moves twice as fast as the slow pointer.
        while (fast != null && fast.next != null) {
            slow = slow.next;           // Slow moves one step.
            fast = fast.next.next;      // Fast moves two steps.
        }

        // At this point, 'slow' points to the middle of the list.
        
        // Step 2: Reverse the second half of the linked list starting from 'slow'.
        ListNode prev = null;          // Initialize a 'prev' pointer for reversal.
        ListNode next = null;          // Temporary pointer to hold the next node.

        while (slow != null) {
            next = slow.next;          // Store the next node.
            slow.next = prev;          // Reverse the current node's pointer.
            prev = slow;               // Move 'prev' one step forward.
            slow = next;               // Move 'slow' to the next node.
        }

        // At this point, 'prev' points to the head of the reversed second half.
        
        // Step 3: Traverse the first half and the reversed second half to find the maximum twin sum.
        ListNode start = head;         // Pointer to traverse the first half.
        int maxSum = 0;                // Variable to store the maximum twin sum.

        while (prev != null) {         // Traverse the reversed second half using 'prev'.
            maxSum = Math.Max(maxSum, prev.val + start.val); // Calculate the twin sum and update maxSum.
            prev = prev.next;          // Move to the next node in the reversed second half.
            start = start.next;        // Move to the next node in the first half.
        }

        // Return the maximum twin sum found.
        return maxSum;
    }
}
