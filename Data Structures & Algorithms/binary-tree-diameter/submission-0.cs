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
                int maxDiameter = 0;
                    private int CalculateDepth(TreeNode root) 
                        {
                                if (root == null) return 0;

                                        int leftDepth = CalculateDepth(root.left);
                                                int rightDepth = CalculateDepth(root.right);

                                                        maxDiameter = Math.Max(maxDiameter, leftDepth + rightDepth);

                                                                return 1 + Math.Max(leftDepth, rightDepth);
                                                                    }
                                                                        public int DiameterOfBinaryTree(TreeNode root) {
                                                                                
                                                                                        CalculateDepth(root);
                                                                                                
                                                                                                        return maxDiameter;
                                                                                                            }
                                                                                                            }