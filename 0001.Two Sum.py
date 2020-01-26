class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        l = len(nums)
        a = {}
        for i in range(l):
            sub = target - nums[i]
            if nums[i] in a:
                return a[nums[i]], i
            else:
                a[sub] = i