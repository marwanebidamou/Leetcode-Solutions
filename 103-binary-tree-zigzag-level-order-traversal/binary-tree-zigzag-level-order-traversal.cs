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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        // If the tree is empty, return an empty list.
        if (root == null)
            return new List<IList<int>>();

        // Result list to store the zigzag level order traversal.
        IList<IList<int>> zigzagOrder = new List<IList<int>>();

        // Queue for level-order traversal (BFS).
        Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
        nodeQueue.Enqueue(root); // Start with the root node.

        // Flag to toggle between left-to-right and right-to-left order.
        bool isLeftToRight = true;

        // Continue the traversal until all nodes are processed.
        while (nodeQueue.Any()) {
            // Number of nodes at the current level.
            int nodesAtCurrentLevel = nodeQueue.Count;

            // List to store the current level's values.
            LinkedList<int> currentLevelValues = new LinkedList<int>();

            // Process all nodes at the current level.
            for (int i = 0; i < nodesAtCurrentLevel; i++) {
                // Dequeue the front node.
                TreeNode currentNode = nodeQueue.Dequeue();

                // Add the node's value to the list in the appropriate order.
                if (isLeftToRight) {
                    currentLevelValues.AddLast(currentNode.val); // Append to the end.
                } else {
                    currentLevelValues.AddFirst(currentNode.val); // Insert at the beginning.
                }

                // Enqueue the left and right children if they exist.
                if (currentNode.left != null)
                    nodeQueue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    nodeQueue.Enqueue(currentNode.right);
            }

            // Add the current level's values to the result.
            zigzagOrder.Add(new List<int>(currentLevelValues));

            // Toggle the order for the next level.
            isLeftToRight = !isLeftToRight;
        }

        // Return the zigzag level order traversal result.
        return zigzagOrder;
    }
}