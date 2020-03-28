# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def lowestCommonAncestor(self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> 'TreeNode':
        
        point = root
        
        while point:
            if p.val > point.val and q.val > point.val: #pq都大於當前節點 就往右邊繼續找
                point = point.right
            elif p.val < point.val and q.val < point.val: #pq都小於當前節點 就往左邊繼續找
                point = point.left
            else: #pq 其中一個等於當前節點 或者剛好一個大於一個小於 代表該節點為pq的LCA(共同的頭)
                return point