class Solution:
    def countAndSay(self, n: int) -> str:
        read  = '1'
        for i in range(n-1):
            new_read = ''
            j = 0
            while j < len(read):
                count = 1
                while j < len(read)-1 and read[j] == read[j+1]:
                    j = j + 1
                    count = count + 1
                j = j + 1
                
                new_read  = new_read + str(count) + read[j-1]
            read  = new_read
        return read 
