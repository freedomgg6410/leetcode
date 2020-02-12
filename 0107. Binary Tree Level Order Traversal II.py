# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def levelOrderBottom(self, root: TreeNode) -> List[List[int]]:
        res = []
        self.dfs(root, 0, res)
        return res

    def dfs(self, root, depth, res):
        if root:
            if depth >= len(res):
                res.insert(0, [])
            res[-(depth+1)].append(root.val)
            self.dfs(root.left, depth+1, res)
            self.dfs(root.right, depth+1, res)
