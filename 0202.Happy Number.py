class Solution:
    def isHappy(self, n: int) -> bool:
        
        array = []
        
        while n != 1 and n not in array:
            array.append(n)
            sum = 0
            while n: #各位數平方相加
                sum += (n % 10)*(n % 10)
                n = int(n/10)
            n = sum

        return n == 1