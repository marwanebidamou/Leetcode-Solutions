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
    public IList<int> InorderTraversal(TreeNode root) {
        if(root == null)
            return new List<int>();

        return GetInOrderTraversal(root);
    }

    List<int> GetInOrderTraversal(TreeNode node)
    {   
        if(node == null)
            return new List<int>();

        var left = GetInOrderTraversal(node.left);
        var middle = new List<int> {node.val};
        var right = GetInOrderTraversal(node.right);
        
        return left.Concat(middle).Concat(right).ToList();

    }
}