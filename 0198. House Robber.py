class Solution:
    def rob(self, nums: List[int]) -> int:
        maxA = []
        
        if len(nums) == 0 : 
            return 0
    
        if len(nums) == 1 : 
            return nums[0]
    
        if len(nums) == 2 : 
            return max(nums[1],nums[0])

        maxA.append(nums[0])
        maxA.append(max(nums[0],nums[1]))

        for i in range(2,len(nums)) :
            #最大金額   = Max(現在金額+前前一棟最大金額 ， 前一棟最大金額)
            maxA.append(max(nums[i] + maxA[i-2] , maxA[i-1]))
        
        
        return maxA.pop()