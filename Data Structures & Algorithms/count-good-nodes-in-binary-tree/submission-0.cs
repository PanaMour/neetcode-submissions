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
    private int DFS(TreeNode root, int maxSoFar) {
        if (root == null)
            return 0;
        int goodCount = 0;
        if (root.val >= maxSoFar) {
            goodCount = 1;
        }
        int newMax = Math.Max(maxSoFar, root.val);

        goodCount += DFS(root.left, newMax);
        goodCount += DFS(root.right, newMax);
        return goodCount;
    }
    public int GoodNodes(TreeNode root) {
        return DFS(root, root.val);
    }
}
