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
    public IList<int> LargestValues(TreeNode root) {
        // If the tree is empty, return an empty list.
        if(root == null)
            return new List<int>();
        
        // List to store the largest values for each row.
        IList<int> result = new List<int>();

        // Queue for BFS to traverse the tree level by level.
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root); // Start with the root node.

        // Continue traversal until there are no nodes left in the queue.
        while(queue.Any())
        {
            // Initialize the maximum value for the current level.
            int maxValOfCurrLevel = int.MinValue;

            // Get the number of nodes in the current level.
            int currentLevelCount = queue.Count;

            // Process all nodes in the current level.
            for(int i = 0; i < currentLevelCount; i++)
            {
                // Dequeue the front node from the queue.
                TreeNode currentNode = queue.Dequeue();

                // Update the maximum value for the current level.
                maxValOfCurrLevel = Math.Max(maxValOfCurrLevel, currentNode.val);

                // Add the left child to the queue if it exists.
                if(currentNode.left != null)
                    queue.Enqueue(currentNode.left);

                // Add the right child to the queue if it exists.
                if(currentNode.right != null)
                    queue.Enqueue(currentNode.right);                
            }

            // After processing the level, add the maximum value to the result list.
            result.Add(maxValOfCurrLevel);
        }

        // Return the list of largest values for each row.
        return result;
    }
}