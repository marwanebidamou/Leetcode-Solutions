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
    public int RangeSumBST(TreeNode root, int low, int high) {       
        // Use a helper function to perform the range sum calculation.
        return CalculateRangeSum(root, low, high);
    }

    private int CalculateRangeSum(TreeNode node, int low, int high) {
        // Base case: If the current node is null, return 0 (no contribution to the sum).
        if (node == null)
            return 0;

        // Initialize the sum for the current subtree.
        int rangeSum = 0;

        // Include the current node's value if it is within the range [low, high].
        if (node.val >= low && node.val <= high)
            rangeSum += node.val;

        // Recur for the left subtree if the current node's value is greater than or equal to `low`.
        // This ensures we only consider nodes that might have values within range.
        if (node.val >= low)
            rangeSum += CalculateRangeSum(node.left, low, high);

        // Recur for the right subtree if the current node's value is less than or equal to `high`.
        // This ensures we only consider nodes that might have values within range.
        if (node.val <= high)
            rangeSum += CalculateRangeSum(node.right, low, high);

        // Return the total sum for this subtree.
        return rangeSum;
    }
}