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

    private int GetGreatestCommomDivisor(int x, int y)
    {
        int min = Math.Min(x,y);

        for(int num = min;num>0;num--)
        {
            if(x%num == 0 && y%num==0)
                return num;
        }

        return 1;
    }
}