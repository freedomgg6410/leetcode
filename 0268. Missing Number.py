class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        nums.sort()
        i = 0
        while i < len(nums):
            if nums[i] != i :
                return i
            else:
                i += 1
        return i
