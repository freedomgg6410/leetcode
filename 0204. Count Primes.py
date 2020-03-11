class Solution:
    def countPrimes(self, n: int) -> int:
        
        if n < 3 :
            return 0;

        count = 1;
    
        for i in range(3,n,2):
            flag = 1
            fi = int(i**0.5)
            for j in range(3,fi+1,2):
                if i%j == 0:
                    flag = 0
                    break
                
            

            if flag == 1: 
                count+=1
        

        return count