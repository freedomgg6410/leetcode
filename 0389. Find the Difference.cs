public class Solution {
    public char FindTheDifference(string s, string t) {
        
        int[] chars = new int[26];
        
        //將s的字母出現次數記錄在chars中
        for(int i=0 ; i<s.Length ; i++){
            chars[s[i] - 'a']++;
        }
        
        //將chars減去t的字母出現次數 
        for(int i=0 ; i<t.Length ; i++){
            chars[t[i] - 'a']--;
        }
        
        //不等於0的為多餘的字母
        for(int i=0 ; i<chars.Length ; i++){
            if(chars[i]!=0){
                return (char) ('a' + i);
            }
        }
        
        return '0';

    }
}