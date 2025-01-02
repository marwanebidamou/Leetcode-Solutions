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
    public int ClosestValue(TreeNode root, double target) {        
        return Helper(root, target, root.val);
    }

    private int Helper(TreeNode root, double target,int closest)
    {
        if(root==null)
            return closest;

        if(root.val == target)
            return root.val;
        
        double oldClosest = Math.Abs(target-closest);
        double newClosest = Math.Abs(target-root.val);

        if(oldClosest == newClosest)
            closest = Math.Min(closest, root.val);
        else
            closest = newClosest < oldClosest ? root.val : closest;

        var closesValueInLeft = Helper(root.left, target, closest);
        var closesValueInRight = Helper(root.right,target, closest);

        if(Math.Abs(target-closesValueInLeft) == Math.Abs(target-closesValueInRight))
            return Math.Min(closesValueInLeft, closesValueInRight);
        else
            return Math.Abs(target-closesValueInLeft) <  Math.Abs(target-closesValueInRight) ? closesValueInLeft: closesValueInRight;

    }
}