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
    private int count;
    private int result;
    private void InOrderDFS(TreeNode node, int k) {
        if (node == null || count >= k)
            return;

        InOrderDFS(node.left, k);
        count++;
        if (count == k)
            result = node.val;
        InOrderDFS(node.right, k);
        return;
    }
    public int KthSmallest(TreeNode root, int k) {
        count = 0;
        result = -1;
        InOrderDFS(root, k);

        return result;
    }
}
