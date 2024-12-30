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

    public int GoodNodes(TreeNode root) {
        return dfs(root, int.MinValue);
    }

    int dfs(TreeNode node, int maxSoFar)
    {
        // Base case: If the current node is null, return 0 since there are no nodes to process
        if(node == null)
            return 0;

        // Recursively traverse the left subtree, updating the maximum value encountered so far
        int left = dfs(node.left, Math.Max(maxSoFar, node.val));
        // Recursively traverse the right subtree, updating the maximum value encountered so far
        int right = dfs(node.right, Math.Max(maxSoFar, node.val));
        
        // Initialize the answer with the sum of left and right subtree counts
        int ans = left + right;

        // If the current node's value is greater than or equal to the max value encountered so far,
        // increment the count (this node qualifies as being greater than or equal to all previous nodes)
        if (node.val >= maxSoFar)
            ans += 1;
    
        
        // Return the total count 
        return ans;
    }
    
    
}