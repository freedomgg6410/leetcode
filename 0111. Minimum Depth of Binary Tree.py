# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def minDepth(self, root: TreeNode) -> int:
        
        if root is None :
            return 0 
        
        if root.left and root.right :
            return min(self.minDepth(root.left),self.minDepth(root.right)) + 1
        else : 
            return max(self.minDepth(root.left),self.minDepth(root.right)) + 1
        """其中一邊沒有子節點 return 比較大的那邊(因為另一邊為0)"""