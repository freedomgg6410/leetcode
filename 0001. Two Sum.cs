public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1 ; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    int[] array = new int[2];
                    array[0] = i;
                    array[1] = j;
                    
                    return array;
                    
                }
            }
        
        }
        
        throw new System.ArgumentException(""); //擲回例外狀況
        
        
    }
}