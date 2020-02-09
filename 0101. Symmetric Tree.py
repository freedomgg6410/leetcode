# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def isSymmetric(self, root: TreeNode) -> bool:
        
        if root==None:
            return True
        
        return self.symmetry(root.left,root.right)
    
    def symmetry(self,left,right):
        
        if left==None and right==None:
            return True
        
        if left and right and left.val==right.val:
            return self.symmetry(left.left,right.right) and self.symmetry(left.right,right.left)
        else:
            return False