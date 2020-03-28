/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int min = 0 ;
        int max = n ;
        int mid;

        // 用二分法進行搜尋，減少loop次數
        while(max > min){
            mid = min + ((max-min)/2); 
            if(IsBadVersion(mid)){
                max = mid;
            } else {
                min = mid+1;
            }
        }

        return max;
    }
}