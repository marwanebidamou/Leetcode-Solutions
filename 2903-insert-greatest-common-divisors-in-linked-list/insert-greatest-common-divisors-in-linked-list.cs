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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        ListNode dummy = head;

        while(dummy?.next!=null)
        {
            var curr = dummy.val;
            var next = dummy.next;

            var commmDivisor = GetGreatestCommomDivisor(curr, next.val);

            dummy.next = new ListNode(commmDivisor, next);

            dummy = dummy.next.next;
        }

        return head;
    }

    private int GetGreatestCommomDivisor(int p, int q)
    {
        if(q == 0)
        {
            return p;
        }

        int r = p % q;

        return GetGreatestCommomDivisor(q, r);
    }
}