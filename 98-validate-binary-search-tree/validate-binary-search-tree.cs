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
    public bool IsValidBST(TreeNode root) {
        // Start validating the tree with the full range of possible integer values.
        return IsValidBSTHelper(root, long.MinValue, long.MaxValue);
    }

    private bool IsValidBSTHelper(TreeNode root, long min, long max) {
        // Base case: If the current node is null, it is valid as it doesn't violate any BST properties.
        if (root == null)
            return true;

        // Check if the current node's value violates the min/max constraints.
        // A valid BST requires that all nodes in the left subtree are less than the current node,
        // and all nodes in the right subtree are greater than the current node.
        if (root.val <= min || root.val >= max)
            return false;

        // Recursively validate the left subtree.
        // Update the maximum allowable value for the left subtree to be the current node's value.
        bool isValidLeftBST = IsValidBSTHelper(root.left, min, root.val);

        // Recursively validate the right subtree.
        // Update the minimum allowable value for the right subtree to be the current node's value.
        bool isValidRightBST = IsValidBSTHelper(root.right, root.val, max);

        // Return true if both the left and right subtrees are valid BSTs.
        return isValidLeftBST && isValidRightBST;
    }
}
