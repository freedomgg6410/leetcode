public class Solution {
    public int FirstUniqChar(string s) {
         if (s == null || s.Length == 0) return -1;
        
        //26個小寫在這邊存好
        int[] count = new int[26];
        
        //相應字母count++
        for (int i = 0; i < s.Length; ++i){
            count[s[i] - 'a']++;
        }
        
        
        //找出s裡面 count 為 1 的第一個字母
        for (int i = 0; i < s.Length; ++i){
            if (count[s[i] - 'a'] == 1){
                return i;
            } 
        }
            
        return -1;
    }
}