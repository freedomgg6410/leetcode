class Solution:
    def isIsomorphic(self, s: str, t: str) -> bool:
       
        hashmap = {}
        mapval = {}
        for i in range(len(s)):
            if s[i] in hashmap:
                if hashmap[s[i]] != t[i]:
                    return False
            elif t[i] in mapval:
                return False
            else:
                hashmap[s[i]] = t[i]
                mapval[t[i]] = True
        return True
