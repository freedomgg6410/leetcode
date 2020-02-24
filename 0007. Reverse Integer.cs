public class Solution {
    public int Reverse(int x) {
        int ans = 0;
            while (x != 0)
            {
                int pop = x % 10;
                
                if (ans > int.MaxValue / 10 || (ans == int.MaxValue / 10 && pop > 7)){      
                    return 0;
                }
                    
                
                if (ans < int.MinValue / 10 || (ans == int.MinValue / 10 && pop < -8)){
                    return 0;
                }
                    
                ans = ans * 10 + pop;
                x /= 10;
                
            }
        
            return ans;
   
    }
}