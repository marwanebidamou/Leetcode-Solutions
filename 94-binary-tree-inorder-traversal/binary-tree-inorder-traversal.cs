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

        List<int> output = new List<int>();
        GetInOrderTraversal(root, output);
        return output;
    }

    void GetInOrderTraversal(TreeNode node, List<int> list)
    {   
        if(node == null)
            return;

       GetInOrderTraversal(node.left, list);
       list.Add(node.val);
       GetInOrderTraversal(node.right, list);
        
    }
}