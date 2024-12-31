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
    public int GetMinimumDifference(TreeNode root) {
        // Edge case: If the tree is empty, return 0 (although the problem guarantees a valid tree).
        if (root == null)
            return 0;

        // List to store the node values in sorted order after in-order traversal.
        List<int> sortedValues = new List<int>();

        // Perform in-order traversal to collect node values.
        InOrderTraversal(root, sortedValues);

        // Variable to store the minimum absolute difference found so far.
        int minimumDifference = int.MaxValue;

        // Compare consecutive values in the sorted list to calculate the minimum difference.
        for (int i = 1; i < sortedValues.Count; i++) {
            int difference = Math.Abs(sortedValues[i] - sortedValues[i - 1]);
            minimumDifference = Math.Min(minimumDifference, difference);
        }

        return minimumDifference;
    }

    // Helper function to perform in-order traversal and collect node values.
    private void InOrderTraversal(TreeNode node, List<int> values) {
        // Base case: If the node is null, return.
        if (node == null)
            return;

        // Recur for the left subtree.
        InOrderTraversal(node.left, values);

        // Add the current node's value to the list.
        values.Add(node.val);

        // Recur for the right subtree.
        InOrderTraversal(node.right, values);
    }
}