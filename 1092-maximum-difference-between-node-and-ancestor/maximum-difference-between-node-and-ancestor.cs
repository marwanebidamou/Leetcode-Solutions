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
    public int MaxAncestorDiff(TreeNode root) {
        return Dfs(root, min:int.MaxValue, max:int.MinValue);
    }

    private int Dfs(TreeNode root, int min, int max)
    {
        if(root==null)
            return max-min;

        min=Math.Min(min, root.val);
        max=Math.Max(max, root.val);

        return Math.Max(Dfs(root.left, min, max) , Dfs(root.right, min, max));

    }
}