class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        """
        Do not return anything, modify nums1 in-place instead.
        """
        
        nums = [n1 for i, n1 in enumerate(nums1) if i < m] + [n2 for i, n2 in enumerate(nums2) if i < n]
        nums.sort()
        for i, num in enumerate(nums):
            nums1[i] = num