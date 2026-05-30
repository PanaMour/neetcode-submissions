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
    int maxSum;
    private int DFSMaxPathSum(TreeNode node) {
        if (node == null)
            return 0;
        int leftSum = Math.Max(0, DFSMaxPathSum(node.left));
        int rightSum = Math.Max(0, DFSMaxPathSum(node.right));
        int currentArch = node.val + leftSum + rightSum;
        maxSum = Math.Max(maxSum, currentArch);

        return node.val + Math.Max(leftSum, rightSum);
    }
    public int MaxPathSum(TreeNode root) {
        maxSum = int.MinValue;
        DFSMaxPathSum(root);
        return maxSum;
    }
}
