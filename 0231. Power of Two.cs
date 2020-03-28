public class Solution {
    public bool IsPowerOfTwo(int n) {
        
        if (n < 1){
            return false;
        }
            
        
        while (n%2 == 0){
            n = n / 2;
        }
            
            
        if (n==1){
            return true;
        }else{
            return false;
        }
            
            
    }
}