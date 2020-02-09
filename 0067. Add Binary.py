class Solution:
    def addBinary(self, a: str, b: str) -> str:
        sum10 = int(a, 2) + int(b, 2)
        
        
        return bin(sum10)[2:]