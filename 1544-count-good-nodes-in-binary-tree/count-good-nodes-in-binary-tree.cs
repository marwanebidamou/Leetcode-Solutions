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
        if(node == null)
            return 0;

        int toAdd = 0;
        if(node.val>= maxSoFar)
        {
            maxSoFar = Math.Max(maxSoFar, node.val);
            toAdd = 1;
        }

        return toAdd + dfs(node.left,maxSoFar) + dfs(node.right,maxSoFar);
    }

    
}