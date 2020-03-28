public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);
        
        int i = 0;
        while(i < nums.Length){
            if (nums[i] != i){
                return i;
            }else{
                i += 1;
            }
            
        }
            
        return i;
    }
}