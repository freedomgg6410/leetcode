public class Solution {
    public void Rotate(int[] nums, int k) {
        
        k = k % nums.Length;
    
        reverse(nums , 0 , nums.Length - k - 1);
        reverse(nums , nums.Length - k , nums.Length - 1);
        reverse(nums , 0 , nums.Length - 1);


    }
    
    
    public void reverse(int[] nums , int start , int end){
        while(start < end){
            int tmp = nums[start];
            nums[start] = nums[end];
            nums[end] = tmp;
            start ++;
            end --;
        }
    }

}