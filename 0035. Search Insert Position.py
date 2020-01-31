class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:
        if len(nums) == 0:
            return 0

        for i in range(len(nums)):
            if target < nums[i]:
                nums.insert(0,target)
                return 0
            
            elif target == nums[i]:
                return i
            
            elif i < len(nums)-1 and target > nums[i] and target < nums[i+1]:
                nums.insert(i+1, target)
                return i+1
            
            elif i == len(nums) - 1:
                nums.append(target)
                return len(nums) - 1