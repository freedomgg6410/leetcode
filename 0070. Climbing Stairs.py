class Solution:
    def climbStairs(self, n: int) -> int:
        """費氏數列"""
        
        a = b = 1
        for i in range(1, n):
            c = a
            a = b 
            b = c+b
        return b
