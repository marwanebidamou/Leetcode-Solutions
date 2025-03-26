/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        
        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        TreeNode successor = null;
        while(queue.Any())
        {
            var curr = queue.Dequeue();

            if(curr.val > p.val){
                if(successor==null || successor.val > curr.val){
                    successor = curr;
                }
            }

            if(curr.left!=null)
                queue.Enqueue(curr.left);
            
            if(curr.right!=null)
                queue.Enqueue(curr.right);
            
        }

        return successor;

    }
}