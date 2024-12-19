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
    public bool HasCycle(ListNode head) {

        /* 
        //Solving the problem using HashSet

        HashSet<ListNode> map = new HashSet<ListNode>();

        while(head!=null){
            if(!map.Add(head))
                return true;
            head = head.next;
        }
        return false;

        */

        //Solving the problem using slow / fast pointer
        ListNode fast = head;
        ListNode slow = head;

        while(fast?.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;


            // If the 'fast' pointer meets the 'slow' pointer, it means there is a cycle.
            // This is because both pointers are now inside the cycle, and since 'fast' moves
            // twice as fast as 'slow', it will eventually "lap" the slower pointer.
            if(fast == slow)
                return true;
        }

        return false;
    }
}