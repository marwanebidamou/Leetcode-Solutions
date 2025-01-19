/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        // Use a HashSet to store nodes of list A
        HashSet<ListNode> nodeSet = new HashSet<ListNode>();
        
        // Traverse through list A and add each node to the HashSet
        while (headA != null) {
            nodeSet.Add(headA);
            headA = headA.next;
        }
        
        // Traverse through list B and check if any node is in the HashSet
        while (headB != null) {
            if (nodeSet.Contains(headB)) {
                return headB; // Found the intersection node
            }
            headB = headB.next;
        }
        
        // No intersection
        return null;
    }
}
