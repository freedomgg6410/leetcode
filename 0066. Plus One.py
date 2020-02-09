class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        
        x = 1
        for i in range(len(digits)-1, -1, -1):
            if digits[i] + x == 10:
                digits[i] = 0
                x = 1
            else:
                digits[i] = digits[i] + x
                x = 0
                
        if x == 1:
            digits.insert(0,1)
            
        return digits