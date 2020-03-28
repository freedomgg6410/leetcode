public class Solution {
    public void MoveZeroes(int[] nums) {
        int index = 0;
        for(int i = 0 ; i < nums.Length ; i++){
            int n = nums[i]; 
            // 非0的數先排到前面
            if(n != 0){
                nums[index++] = n;    
            }
        }

        // 排完後把0補上
        for(int i = index ; i < nums.Length ; i++){
            nums[i] = 0;
        }
    }
}