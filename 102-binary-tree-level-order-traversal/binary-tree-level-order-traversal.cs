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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        // List to store the final result (each level as a separate list)
        IList<IList<int>> result = new List<IList<int>>();

        // Edge case: if the tree is empty, return an empty list
        if (root == null)
            return result;

        // Queue to help with BFS traversal
        Queue<TreeNode> queue = new Queue<TreeNode>();        
        queue.Enqueue(root); // Start by enqueuing the root node

        // Loop while there are nodes to process in the queue
        while (queue.Any()) {
            int count = queue.Count(); // Number of nodes at the current level

            // List to store the values of the current level
            IList<int> list = new List<int>();

            // Process all nodes at the current level
            for (int i = 1; i <= count; i++) {
                var node = queue.Dequeue(); // Dequeue a node

                list.Add(node.val); // Add the node's value to the level list

                // Enqueue left and right children if they exist
                if (node.left != null) {
                    queue.Enqueue(node.left);
                }
                if (node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            
            // Add the current level's list to the result
            result.Add(list);
        }

        return result; // Return the level-order traversal result
    }
}