public class Solution {
    public bool IsPowerOfThree(int n) {
        while(n>2){
            if(n%3 != 0) {
                return false;
            }
            n = n/3;
        }

        return n==1;
    }
}