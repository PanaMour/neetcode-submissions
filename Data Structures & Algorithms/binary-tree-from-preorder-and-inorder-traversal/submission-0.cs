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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0)
            return null;
        TreeNode root = new TreeNode(preorder[0]);

        int mid = Array.IndexOf(inorder, root.val);
        int[] leftPreorder = preorder.Skip(1).Take(mid).ToArray();
        int[] leftInorder = inorder.Take(mid).ToArray();

        int[] rightPreorder = preorder.Skip(1 + mid).ToArray();
        int[] rightInorder = inorder.Skip(mid + 1).ToArray();

        root.left = BuildTree(leftPreorder, leftInorder);
        root.right = BuildTree(rightPreorder, rightInorder);

        return root;
    }
}
