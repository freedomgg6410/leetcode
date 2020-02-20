public class Solution {
    public int MaxProfit(int[] prices) {
        
        if(prices.Length == 0){
            return 0 ;
        }
        
        int min = prices[0];
        int max = 0;
        
        for(int i = 0 ; i<prices.Length ;i++){
            if(prices[i] < min){
                min = prices[i];
            }else if(prices[i]-min > max){
                max = prices[i] - min;
            }
        }
        
        return max;
        
        
    }
}

