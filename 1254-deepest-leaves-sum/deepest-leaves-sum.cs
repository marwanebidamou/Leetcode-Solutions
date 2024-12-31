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
    public int DeepestLeavesSum(TreeNode root) {
        if(root == null)
            return 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int sumOfValues = 0;

        while(queue.Any())
        {
            int currentLevelSum = 0;
            int currentLevelNodesCount = queue.Count;

            for(int i=0;i<currentLevelNodesCount;i++)
            {
                TreeNode node = queue.Dequeue();
                currentLevelSum += node.val;

                if(node.left != null)
                    queue.Enqueue(node.left);
                
                if(node.right != null)
                    queue.Enqueue(node.right);                
            }
            sumOfValues = currentLevelSum;
        }

        return sumOfValues;
    }
}