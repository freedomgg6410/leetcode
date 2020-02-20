class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        
        array = []
        
        for i in range(numRows):
            array.append([])
            
            for j in range(i+1) :
                #第一項及最後一項 都為1
                if j in (0,i):
                    array[i].append(1)
                #中間每項都是上一行的 第j-1項 + 第j項 j=當前項次
                else :
                    array[i].append(array[i-1][j-1] + array[i-1][j])
        
        return array
                    