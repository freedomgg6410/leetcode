class Solution:
    def romanToInt(self, s: str) -> int:
        
        RomanNum = {"I":1, "V":5, "X":10, "L":50, "C":100, "D":500, "M":1000}
        sum = 0
        maxDigit = 1
        for i in range(len(s)-1, -1, -1):
            if RomanNum[s[i]] >= maxDigit:
                maxDigit = RomanNum[s[i]]
                sum += RomanNum[s[i]]
            else:
                sum -= RomanNum[s[i]]

        return sum