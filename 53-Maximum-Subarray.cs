class Solution {
    public int maxSubArray(int[] nums){
		int sum = 0, result = nums[0];
		
		for(int i=0; i<nums.length; i++){
			sum += nums[i];
			result = Math.max(result, sum);
			sum = Math.max(sum, 0);
		}
		
		return result;
	}
}