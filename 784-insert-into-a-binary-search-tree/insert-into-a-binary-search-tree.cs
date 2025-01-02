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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null)
            return new TreeNode(val);
            
        TreeNode dummy = root;
        
        while(true)
        {
            if(dummy.val>val)
            {
                if(dummy.left == null)
                {
                    dummy.left = new TreeNode(val);
                    return root;
                }
                else
                {
                    dummy = dummy.left;
                }
            }
            else
            {
                if(dummy.right == null)
                {
                    dummy.right = new TreeNode(val);
                    return root;
                }
                else
                {
                    dummy = dummy.right;
                }
            }
        }

        return root;
    }
}