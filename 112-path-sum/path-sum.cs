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

    int target;
    /*Recursive Solution*/
    public bool HasPathSum(TreeNode root, int targetSum) {
    {
        target = targetSum;
        return dfs(root, 0);
    }

    bool dfs(TreeNode node, int currentSum)
    {
        //Base case
        if(node == null)
            return false;

        // Add the current node's value to the cumulative sum.
        currentSum+=node.val;

        // Check if the current node is a leaf and the cumulative sum matches the target.
        if(node.left == null && node.right == null)
            return currentSum == target;
        
        // Recursively check the left and right subtrees.
        return dfs(node.left, currentSum) || dfs(node.right, currentSum);
    }

    /* Iterative Solution
    public bool HasPathSum(TreeNode root, int targetSum) {
        
        if(root==null)
            return false;       

        Stack<Pair> stack = new Stack<Pair>();
        stack.Push(new Pair {node= root, sum = root.val});
        while(stack.Count > 0)
        {
            Pair pair = stack.Pop();

            if(pair.node.left == null && pair.node.right == null && pair.sum ==targetSum)
                return true;

            if(pair.node.left!=null)
                stack.Push(new Pair {node= pair.node.left, sum = pair.sum + pair.node.left.val});

            if(pair.node.right!=null)
                stack.Push(new Pair {node= pair.node.right, sum = pair.sum + pair.node.right.val});

        }
        return false;
    }*/
}
}

/*
class Pair
{
    public TreeNode node {get; set;}
    public int sum {get; set;}
}
*/