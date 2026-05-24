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
    Dictionary<int, List<int>> res = new Dictionary<int, List<int>>();

    private void DFS(TreeNode root, int level) {
        if (root == null)
            return;
        if (!res.ContainsKey(level)) {
            res[level] = new List<int>();
        }

        res[level].Add(root.val);
        DFS(root.left, level + 1);
        DFS(root.right, level + 1);

        return;
    }
    public List<List<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();
        if (root == null)
            return result;
        DFS(root, 0);

        for (int i = 0; i < res.Count; i++) {
            result.Add(res[i]);
        }

        return result;
    }
}
