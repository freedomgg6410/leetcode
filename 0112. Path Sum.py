# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def hasPathSum(self, root: TreeNode, sum: int) -> bool:
        
        if root is None :
            return False
        
        #確認為無任何子節點(leaf) 且值為SUM(因為遞迴沒一層都會減sum的值 所以最後的root.val == sum代表整條路徑的總和 = sum)
        if root.left is None and root.right is None and root.val == sum :
            return True
        #非leaf 就sum-root.val 繼續往左邊或右邊走
        else :
            return self.hasPathSum(root.left , sum - root.val ) or self.hasPathSum(root.right , sum - root.val )
            