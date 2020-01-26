class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        if not strs: return ""
        str1 = min(strs)
        str2 = max(strs)
        
        for i, j in enumerate(str1):
            if j != str2[i]:
                return str1[:i]
        return str1   