public class Solution {
    public uint reverseBits(uint n) {
        uint ans = 0;
        
        //位元運算 ( ans << 1 ) ans左移1位 ( n & 1 ) 判斷n的最後1位是0還是1
        for(var i = 0 ; i<32 ; i++){
            ans = ( ans << 1 ) + ( n & 1 ); //等於數字運算的 ans = (ans/2) + (ans%2)
            n = n >> 1;
        }
        
        return ans;
        
    }
}