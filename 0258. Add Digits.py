class Solution:
    def addDigits(self, num: int) -> int:
        while num >= 10 :
            n = num
            sum = 0
           
            while int(n/10) > 0:
                sum += int(n%10)
                n = int(n/10) 
            
            num = int(n%10) + sum
            
        
        return num