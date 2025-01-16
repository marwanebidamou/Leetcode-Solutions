/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int LongestZigZag(TreeNode root) {
        if (root == null) return 0;

        int maxZigZag = 0;

        // Recursive DFS function to calculate ZigZag length
        void DFS(TreeNode node, bool isLeft, int length) {
            if (node == null) {
                maxZigZag = Math.Max(maxZigZag, length - 1); // Update the max length
                return;
            }

            // Traverse in both directions
            if (isLeft) {
                DFS(node.left, false, length + 1); // Switch direction to right
                DFS(node.right, true, 1); // Reset the length for a new start
            } else {
                DFS(node.right, true, length + 1); // Switch direction to left
                DFS(node.left, false, 1); // Reset the length for a new start
            }
        }

        // Start DFS from the root in both directions
        DFS(root.left, false, 1); // Left direction
        DFS(root.right, true, 1); // Right direction

        return maxZigZag;
    }
}
