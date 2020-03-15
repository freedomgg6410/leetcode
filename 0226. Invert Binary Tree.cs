/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        
        if (root != null){
            TreeNode Right = new TreeNode(); //暫存左邊的值
            Right.right = InvertTree(root.left); //用遞迴去進行每個節點 左右互換
            root.left = InvertTree(root.right);
            root.right = Right.right;
        }
            
        
        return root;
                
    }
}