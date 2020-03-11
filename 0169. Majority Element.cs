public class Solution {
    public int MajorityElement(int[] nums) {
        var index = 0;
        var count = 1;
        
        for(var i = 1 ; i<nums.Length ; i++){
            if (nums[index] == nums[i]){
                count ++;
            }else{
                count --;
                if (count == 0){
                    index = i;
                    count = 1;
                }
                    
            }
        }
                
        
        return nums[index];
    }
}