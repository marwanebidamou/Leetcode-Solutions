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
    public IList<int> RightSideView(TreeNode root) {
        // If the root is null, there is no tree to traverse, return an empty list.
        if(root == null)
            return new List<int>();

        // Use a queue to facilitate level-order traversal (BFS).
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root); // Start by adding the root node to the queue.

        // This list will store the rightmost node values from each level.
        IList<int> result = new List<int>();

        // Continue the BFS as long as there are nodes in the queue.
        while(queue.Count > 0)
        {
            // Get the number of nodes in the current level.
            int currentLevelCount = queue.Count;

            // Variable to hold the value of the rightmost node at the current level.
            int mostRightNode = 0;

            // Iterate through all the nodes in the current level.
            for(int i = 0; i < currentLevelCount; i++)
            {
                // Remove the front node from the queue.
                var node = queue.Dequeue();

                // Add the left child to the queue if it exists.
                if(node.left != null)
                    queue.Enqueue(node.left);

                // Add the right child to the queue if it exists.
                if(node.right != null)
                    queue.Enqueue(node.right);

                // Update the rightmost node's value (this will be the last node processed in this level).
                mostRightNode = node.val;
            }

            // After processing all nodes in the current level, add the rightmost node to the result.
            result.Add(mostRightNode);
        }

        // Return the list containing the right side view of the binary tree.
        return result;
    }
}