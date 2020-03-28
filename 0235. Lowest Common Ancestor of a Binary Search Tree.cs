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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        TreeNode point = new TreeNode(0);
        point = root;
        
        while (point!=null){
            if (p.val > point.val && q.val > point.val){
                 point = point.right;
            }else if (p.val < point.val && q.val < point.val){
                point = point.left;
            }else{
                return point;
            } 
        }
            
        throw new System.ArgumentException("");  
                
            
    }
}