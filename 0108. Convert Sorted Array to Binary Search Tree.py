# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def sortedArrayToBST(self, nums: List[int]) -> TreeNode:
        
        
        return self.ToBST(nums ,0 ,len(nums)-1)
        
    def ToBST(self,nums,start,end):
        if start > end:
            return None
        
        mid = int((start + end)/2)
        tree = TreeNode(nums[mid])
        tree.left = self.ToBST(nums,start,mid-1)
        tree.right = self.ToBST(nums,mid+1,end)
        
        return tree