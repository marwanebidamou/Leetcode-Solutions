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
    public IList<IList<int>> LevelOrder(TreeNode root) {

        IList<IList<int>> result = new List<IList<int>>();

        if(root == null)
            return result;



        Queue<TreeNode> queue = new Queue<TreeNode>();        
        queue.Enqueue(root);

        while(queue.Any())
        {
            int count = queue.Count();

            IList<int> list = new List<int>();

            for(int i=1;i<=count;i++)
            {
                var node = queue.Dequeue();

                list.Add(node.val);

                if(node.left!=null)
                {
                    queue.Enqueue(node.left);
                }
                if(node.right!=null)
                {
                    queue.Enqueue(node.right);
                }
            }
            
            result.Add(list);
        }

        return result;
    }
}