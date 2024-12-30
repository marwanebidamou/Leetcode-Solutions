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

    int minDepth=int.MaxValue;
    
    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;
            
        dfs(root, 1);
        return minDepth;
    }

    void dfs(TreeNode node,int currentDepth)
    {
        if(node == null)
            return;
        if(node.left == null && node.right == null)
        {            
            minDepth = Math.Min(currentDepth, minDepth);
            return;
        }
        
        dfs(node.right, currentDepth+1);
        dfs(node.left, currentDepth+1);

    }
}