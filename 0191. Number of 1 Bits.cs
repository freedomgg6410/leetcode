public class Solution {
    public int HammingWeight(uint n) {
        uint count = 0;
        for (int i = 0; i < 32; i++) {
            count = count + (n & 1);
            n = n >> 1;
        }
        
        int ans = Convert.ToInt32(count);
        
        return ans;
    }
}