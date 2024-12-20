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
    public int PairSum(ListNode head) {
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>();


        while(head!=null)
        {
            stack.Push(head.val);
            queue.Enqueue(head.val);
            head = head.next;
        }

        int maxSum = 0;
        int length = stack.Count()/2;
        for(int i=0;i<length;i++){
            maxSum = Math.Max(maxSum, queue.Dequeue()+stack.Pop());
        }
        
        return maxSum;
    }
}