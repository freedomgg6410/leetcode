public class Solution {
    public void ReverseString(char[] s) {
        char[] result = new char[s.Length];
        int k = 0;
        
        for(var i = s.Length-1 ; i >= 0 ; i--){
            result[k] =  s[i];
            k++;
        }
        
        for(var j = 0 ; j < s.Length ; j++){
            s[j] = result[j]; 
        }
        
        
    }
}