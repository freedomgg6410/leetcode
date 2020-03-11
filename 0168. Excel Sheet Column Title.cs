public class Solution {
    public string ConvertToTitle(int n) {
        var abcStr = string.Empty; //宣告空字串
        
            
        while(n > 0){
            n--;
            abcStr = Convert.ToChar((n % 26) + 'A') + abcStr;
            n = n/26;
        }
        return abcStr;
            
        
    }
}