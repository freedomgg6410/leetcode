public class Solution {
    public int AddDigits(int num) {
        while(num >= 10){
            int n = num;
            int sum = 0;
       
            while(n/10 > 0){
                sum += n%10;
                n = n/10;  
            }
       
            num = n%10 + sum;
        }
        
        return num;
    }
}