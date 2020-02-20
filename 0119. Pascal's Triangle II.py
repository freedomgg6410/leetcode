class Solution:
    def getRow(self, rowIndex: int) -> List[int]:
        
        array = [1] + [0]*rowIndex
        
        for i in range(rowIndex):
            array[0] = 1
            for j in range(i+1,0,-1):
                array[j] = array[j] + array[j-1]
            
        return array
        