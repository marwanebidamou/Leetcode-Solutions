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
        // Use enumerators to generate leaf sequences
        var leafSeq1 = GetLeafSequence(root1).GetEnumerator();
        var leafSeq2 = GetLeafSequence(root2).GetEnumerator();

        while (leafSeq1.MoveNext()) {
            if (!leafSeq2.MoveNext() || leafSeq1.Current != leafSeq2.Current) {
                return false; // Mismatch in leaf sequence
            }
        }

        // Ensure no remaining leaves in the second tree
        return !leafSeq2.MoveNext();
    }

    private IEnumerable<int> GetLeafSequence(TreeNode root) {
        if (root == null) yield break;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0) {
            var node = stack.Pop();

            if (node.left == null && node.right == null) {
                yield return node.val; // Yield leaf value
            }

            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
        }
    }
}
