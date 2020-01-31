class Solution:
    def isPalindrome(self, x: int) -> bool:
        
        if x >= 0 :
            a = int(str(x)[::-1])
            if x == a :
                return True
            else :
                return False
            
        else:
            return False