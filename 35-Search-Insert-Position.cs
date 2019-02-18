public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
            if (target < nums[0]) return 0;
            if (target > nums[nums.Length - 1]) return nums.Length;

            int retVal = -1;
            for(int i = 0; i<nums.Length; i++)
            {
                if(nums[i] >= target)
                {
                    retVal = i;
                    break;
                }
            }

            return retVal;
    }
}