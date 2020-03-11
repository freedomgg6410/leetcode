public class Solution {
    public int TrailingZeroes(int n) {
        if (n < 5) {
            return 0;
        }
            

        var count = 0;
        
        while (n >= 5){ //5的倍數出現的次數
            count += n/5;
            n = n/5;
        }   
            
    
    
        return count;
    }
}