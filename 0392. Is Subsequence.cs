public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        int si = 0 ;
        int ti = 0 ;
           
        while(si < s.Length && ti < t.Length){
            
            if (t[ti] == s[si]){
                si ++;
            }    
            ti ++;
        } 
                    
        return si == s.Length;

    }
}