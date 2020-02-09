class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        lastW = 0 
        j = len(s)-1
        
        while j>=0:
            if s[j] != ' ':
                break
            j = j - 1

        for i in range(j, -1, -1):
            if s[i] == ' ':
                return lastW
            lastW = lastW + 1
            
        return lastW