public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int retVal = 0;
        
        if(nums.Length == 0) return retVal;
        
        int cur = nums[0];
        retVal++;
        for(int i = 1; i<nums.Length; i++){
            if(cur != nums[i]){
                nums[retVal] = nums[i];
                cur = nums[i];
                retVal++;
            }
        }
        
        return retVal;
    }
}