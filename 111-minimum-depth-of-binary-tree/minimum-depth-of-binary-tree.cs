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
        
    public int MinDepth(TreeNode root) {
        return Dfs(root);
    }

    int Dfs(TreeNode node)
    {
        if(node == null)
            return 0;

        // If only one of child is non-null, then go into that recursion.
        if (node.left == null) {
            return 1 + Dfs(node.right);
        } else if (node.right == null) {
            return 1 + Dfs(node.left);
        }
        
        // Both children are non-null, hence call for both children.
        return 1 + Math.Min(Dfs(node.left), Dfs(node.right));
    }
}