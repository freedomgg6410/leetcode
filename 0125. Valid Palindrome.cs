public class Solution {
    public bool IsPalindrome(string s) {
        
        var sChars = s.ToCharArray(); //字串轉為字元陣列
        int i = 0;
        int j = s.Length - 1;
        
        while(i < j){
            while( i < j && !Char.IsLetterOrDigit(sChars[i])){ //Char.IsLetterOrDigit(char) 判斷字元是否為數字或是英文
                i++;
            }
            while( i < j && !Char.IsLetterOrDigit(sChars[j])){
                j--;
            }
            if(Char.ToLower(sChars[i]) != Char.ToLower(sChars[j])){//Char.ToLower(char) 字元轉成小寫
                return false;
            }
            i++;
            j--;
        }
        
        return true;
            
           
    }
}
