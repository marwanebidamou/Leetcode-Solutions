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

    int count = 0;

    public int GoodNodes(TreeNode root) {
        dfs(root, int.MinValue);
        return count;
    }

    void dfs(TreeNode node, int maxSoFar)
    {
        if(node == null)
            return;

        if(node.val>= maxSoFar)
        {
            maxSoFar = Math.Max(maxSoFar, node.val);
            count++;
        }

        dfs(node.left,maxSoFar);
        dfs(node.right,maxSoFar);
    }

    
}