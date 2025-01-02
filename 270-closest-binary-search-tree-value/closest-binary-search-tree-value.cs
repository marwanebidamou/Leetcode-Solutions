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
    public int ClosestValue(TreeNode root, double target) {
        // Initialize the closest value as the root's value
        int closest = root.val;

        // Traverse the tree iteratively
        while (root != null) {
            // Calculate the current distance and closest distance to the target
            double currentDistance = Math.Abs(target - root.val);
            double closestDistance = Math.Abs(target - closest);

            // Update the closest value if the current value is closer or ties but is smaller
            if (currentDistance < closestDistance || 
                (currentDistance == closestDistance && root.val < closest)) {
                closest = root.val;
            }

            // Determine the direction to move: left or right subtree
            if (target < root.val) {
                root = root.left; // Move left if the target is smaller than the current node value
            } else {
                root = root.right; // Move right if the target is greater or equal
            }
        }

        // Return the closest value found
        return closest;
    }
}
