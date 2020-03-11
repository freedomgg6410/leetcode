class Solution:
    def convertToTitle(self, n: int) -> str:
        abcStr = ""
        
        while n :
            abcStr += chr((n-1)%26 + ord('A'))
            n = int((n-1)/26) 
        
        return abcStr[::-1]