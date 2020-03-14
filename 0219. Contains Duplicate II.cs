public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums.Length <= 1){
            return false;
        } 

        
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0;i<nums.Length;i++){
            var v = nums[i];
            if(map.ContainsKey(v) && (i - map[v] <= k)){
                return true;
            }
            map[v] = i;
        }

        
        return false;
    }
}