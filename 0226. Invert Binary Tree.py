# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def invertTree(self, root: TreeNode) -> TreeNode:
        
        if root is not None:
            Right = TreeNode() #暫存左邊的值
            Right.right = self.invertTree(root.left) #用遞迴去進行每個節點 左右互換
            root.left = self.invertTree(root.right)
            root.right = Right.right
        
        return root