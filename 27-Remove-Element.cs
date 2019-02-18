public class Solution {
    public int RemoveElement(int[] nums, int val) {
       int count = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                if(nums[i] == val)
                {
                    count++;
                    for (int j = i; j<nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[nums.Length - 1] = -1;
                    i = i - 1;
                }
            }
            return nums.Length - count;     
    }
}