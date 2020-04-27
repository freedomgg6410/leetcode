class Solution:
    def wordPattern(self, pattern: str, str: str) -> bool:
        strArray = str.split(' ')
        
        if len(strArray) != len(pattern) :
            return False
        
        mapA = {}
        mapB = {}
        
        for i in range(len(pattern)):
            if pattern[i] in mapA:
                if mapA[pattern[i]] != strArray[i]:
                    return False
            else:
                if strArray[i] in mapB:
                    return False
                mapA[pattern[i]] = strArray[i]
                mapB[strArray[i]] = True
                
        
        return True