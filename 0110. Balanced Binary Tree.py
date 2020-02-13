# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def isBalanced(self, root: TreeNode) -> bool:
        
        ans = self.getHight(root)
        
        if ans >= 0:
            return True
        else:
            return False
    
    """取得高度"""
    def getHight(self,root):
        if root is None:
            return 0
        left_hight = self.getHight(root.left)
        right_hight = self.getHight(root.right)
        
        """最底層 abs(left_hight - right_hight) > 1 rutuen -1"""
        if left_hight == -1 or right_hight == -1 or abs(left_hight - right_hight) > 1:
            return -1
            
        return max(left_hight,right_hight) + 1