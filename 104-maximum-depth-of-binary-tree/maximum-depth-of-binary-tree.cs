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
    /*
    //Recursive implementation
    public int MaxDepth(TreeNode root) {
        if(root == null)
            return 0;

        if(root.left == null && root.right == null)
            return 1;

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        return 1 + Math.Max(leftDepth, rightDepth);
    }
    */
    //Iterative implementation

    public int MaxDepth(TreeNode root)
    {
        // If the root is null, the depth is 0.
        if (root == null)
        {
            return 0;
        }

        // Stack to hold nodes and their associated depths.
        Stack<Pair> stack = new Stack<Pair>();

        // Initialize the stack with the root node at depth 1.
        stack.Push(new Pair { node = root, depth = 1 });

        int maxDepth = 0; //to track the maximum depth encountered.

        // Iterate while there are nodes in the stack.
        while (stack.Count > 0)
        {
            // Pop the current node and its depth from the stack.
            var currentNode = stack.Pop();

            // Update maxDepth with the greater value between current and stored depth.
            maxDepth = Math.Max(maxDepth, currentNode.depth);

            // Push the left child onto the stack if it exists, increasing the depth by 1.
            if (currentNode.node.left != null)
            {
                stack.Push(new Pair { node = currentNode.node.left, depth = currentNode.depth + 1 });
            }

            // Push the right child onto the stack if it exists, increasing the depth by 1.
            if (currentNode.node.right != null)
            {
                stack.Push(new Pair { node = currentNode.node.right, depth = currentNode.depth + 1 });
            }
        }

        return maxDepth;
    }

    /// <summary>
    /// Helper class to store a tree node and its corresponding depth.
    /// </summary>
    class Pair
    {
        public TreeNode node { get; set; } // The tree node.
        public int depth { get; set; }    // The depth of the tree node.
    }
}