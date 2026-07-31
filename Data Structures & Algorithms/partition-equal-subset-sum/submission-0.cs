public class Solution {
    public bool CanPartition(int[] nums) {
        int totalSum = 0;
        for(int i =0; i< nums.Length;i++){
            totalSum += nums[i];
        }
        if(totalSum % 2 != 0) return false;
        int target = totalSum / 2;
        bool[] dp = new bool[target + 1];
        dp[0] = true;

        foreach(int num in nums){
            for(int i=target; i>=num;i--){
                dp[i] = dp[i] || dp[i-num];
            }
        }
        return dp[target];
    }
}
