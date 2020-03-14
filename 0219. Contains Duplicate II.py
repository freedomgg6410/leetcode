class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        if len(nums) <= 1:
            return False
         

        map = {}
        
        for i in range(len(nums)):
            v = nums[i]
            if map.__contains__(v) and (i - map[v] <= k):
                return True
            map[v] = i
        
        return False