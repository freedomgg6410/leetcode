public class Solution {
    public int Rob(int[] nums) {
        List<int> maxA = new List<int>();
        
        if (nums.Length == 0){
            return 0;
        } 
            
        if (nums.Length == 1){
            return nums[0];
        }
        
        if  (nums.Length == 2){
            return Math.Max(nums[1],nums[0]);
        }
        
        
        maxA.Add(nums[0]);
        maxA.Add(Math.Max(nums[0],nums[1]));
        
        for (var i = 2; i<nums.Length ;i++){
            //最大金額  = Max(現在金額+前前一棟最大金額 ， 前一棟最大金額)
            maxA.Add(Math.Max(nums[i] + maxA[i-2] , maxA[i-1]));
        }
            
        
        
        return maxA[nums.Length-1] ;
        
        
        
    }
}

