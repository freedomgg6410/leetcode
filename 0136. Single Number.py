class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        ans = 0
        
        for i in nums:
            ans ^= i #XOR 對List進行XOR運算 得到其中的唯一值
    
        return ans