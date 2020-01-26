class Solution(object):
    def removeDuplicates(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        
        if not nums:return 0
        
        numlen = len(nums)
        j  = 0
        for i in range(1,len(nums)):
            if nums[j] != nums[i]:
                j += 1
                nums[j] = nums[i]
                
 
        return j+1
