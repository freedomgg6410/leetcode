class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        
        if len(prices) == 0:
            return 0
                
        min = prices[0]
        max = 0
                
        for i in prices:
            if i < min:
                min = i
            elif i - min > max:
                max = i - min
                    
        return max