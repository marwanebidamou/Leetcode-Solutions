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
    public ListNode DeleteDuplicates(ListNode head) {
        
        ListNode prev = new ListNode(-101);
        ListNode dummy = head;
        while(dummy!=null){
            if(dummy?.val == prev.val){
                prev.next = dummy.next;
            }else{
                prev = dummy;
            }
            dummy = dummy.next;            
        }

        return head;
    }
}