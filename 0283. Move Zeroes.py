class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        index = 0
        
        for i in range(len(nums)):
            n = nums[i] 
            if n != 0:
                nums[index] = n    
                index = index + 1
        

        
        for j in range(index, len(nums)):
            nums[j] = 0;
        