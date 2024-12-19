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
        if(head.next == null)
            return null;
            
        ListNode dummy = new ListNode(0);

        dummy.next = head;

        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = null;

        while(fast?.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        if(prev!=null){
            prev.next = slow.next;
        }
        return dummy.next;
    }
}