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
    public IList<int> LargestValues(TreeNode root) {
        if(root == null)
            return new List<int>();
        
        IList<int> result = new List<int>();

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Any())
        {
            int maxValOfCurrLevel = int.MinValue;
            int currentLevelCount = queue.Count;

            for(int i=0;i<currentLevelCount;i++)
            {
                TreeNode currentNode = queue.Dequeue();
                maxValOfCurrLevel = Math.Max(maxValOfCurrLevel, currentNode.val);

                if(currentNode.left != null)
                    queue.Enqueue(currentNode.left);

                if(currentNode.right != null)
                    queue.Enqueue(currentNode.right);                

            }

            result.Add(maxValOfCurrLevel);
        }

        return result;

    }
}