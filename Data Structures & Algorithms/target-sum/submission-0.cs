public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        int totalSum = 0;
        foreach(int num in nums){
            totalSum += num;
        }
        if (Math.Abs(target) >  totalSum) return 0;
        if((target + totalSum) % 2 != 0) return 0;
        int subsetTarget = (target + totalSum) / 2;
        int[] dp = new int[subsetTarget+1];
        dp[0] = 1;
        foreach(int num in nums){
            for(int i = subsetTarget;i>=num;i--){
                dp[i] += dp[i - num];
            }
        }
        return dp[subsetTarget];
    }
}
