public class Solution {
    public int CountPrimes(int n) {
        // n = 3的時候，才會出現第一個比n小的質數2
        if(n < 3) return 0;

        var count = 1;
        // 加快速度，所以跳過2的倍數
        for(var i = 3 ; i < n ; i+=2){
            var flag = true;
            // 判斷i是不是質數
            for(var j = 3 ; j*j <= i; j+=2){
                if(i%j == 0){
                    // i能被比自己小的數除盡，表示i不是質數
                    flag = false; 
                    break;
                }
            }

            if(flag) count++;
        }

        return count;
    }
}