class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        Sum = 0
        Max = nums[0]-1
        
        for i in range( 0, len(nums) ):
            if Sum < 0:
                Sum = 0
            Sum = Sum + nums[i]
            Max = max( Sum, Max )

        return Max