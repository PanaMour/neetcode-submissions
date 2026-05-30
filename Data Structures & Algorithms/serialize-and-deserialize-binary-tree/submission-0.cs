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

public class Codec
{
    List<string> list;
    private void DFS(TreeNode node)
    {
        if (node == null)
        {
            list.Add("null");
            return;
        }
        else list.Add(node.val.ToString());
        DFS(node.left);
        DFS(node.right);
        return;
    }
    public string Serialize(TreeNode root)
    {
        list = new List<string>();
        DFS(root);
        return string.Join(",", list);
    }

    private TreeNode BuildTree(Queue<string> queue)
    {
        string currentVal = queue.Dequeue();
        if (currentVal == "null") return null;
        TreeNode node = new TreeNode(int.Parse(currentVal));
        node.left = BuildTree(queue);
        node.right = BuildTree(queue);
        return node;
    }
    public TreeNode Deserialize(string data)
    {
        string[] arr = data.Split(',');
        var queue = new Queue<string>();
        for(int i = 0; i < arr.Length; i++)
        {
            queue.Enqueue(arr[i]);
        }
        return BuildTree(queue);
    }
}
