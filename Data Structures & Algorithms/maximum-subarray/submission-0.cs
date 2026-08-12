public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length == 1) return nums[0];
        int currentSum = nums[0];
        int maxSum = nums[0];
        for(int i=1;i<nums.Length;i++){
            currentSum = Math.Max(nums[i],currentSum+nums[i]);
            maxSum = Math.Max(maxSum,currentSum);
        }
        return maxSum;
    }
}
