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
    public int DeepestLeavesSum(TreeNode root) {
        // If the root is null, there is no tree to traverse, so return 0.
        if(root == null)
            return 0;

        // Use a queue to facilitate level-order traversal (BFS).
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root); // Start with the root node.

        // Variable to store the sum of the deepest leaves.
        int sumOfValues = 0;

        // Continue traversal until there are no nodes left in the queue.
        while(queue.Any())
        {
            // Reset the sum for the current level.
            int currentLevelSum = 0;

            // Get the number of nodes in the current level.
            int currentLevelNodesCount = queue.Count;

            // Process all nodes in the current level.
            for(int i = 0; i < currentLevelNodesCount; i++)
            {
                // Dequeue the front node from the queue.
                TreeNode node = queue.Dequeue();

                // Add the node's value to the current level's sum.
                currentLevelSum += node.val;

                // Add the left child to the queue if it exists.
                if(node.left != null)
                    queue.Enqueue(node.left);

                // Add the right child to the queue if it exists.
                if(node.right != null)
                    queue.Enqueue(node.right);                
            }

            // After processing the level, update the sum of values.
            // This ensures `sumOfValues` always holds the sum of the last level processed.
            sumOfValues = currentLevelSum;
        }

        // Return the sum of the deepest leaves' values.
        return sumOfValues;
    }
}
