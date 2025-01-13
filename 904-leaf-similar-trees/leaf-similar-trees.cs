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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        
        List<int> leaf1 = GetLeafs(root1);
        List<int> leaf2 = GetLeafs(root2);

        return leaf1.SequenceEqual(leaf2);

    }

    public List<int> GetLeafs(TreeNode root)
    {
        List<int> result = new List<int>();
        Stack<TreeNode>  stack= new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Any())
        {
            var curr = stack.Pop();
            if(curr.left == null && curr.right == null)
                result.Add(curr.val);
            else {
                if(curr.left != null)
                    stack.Push(curr.left);
                if(curr.right != null)
                    stack.Push(curr.right);
            }
        }
        return result;
        

    }
}