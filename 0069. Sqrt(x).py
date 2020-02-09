class Solution:
    def mySqrt(self, x: int) -> int:
        num = x
        while num * num > x:
            num = int((num + x / num) / 2)
            
        return num