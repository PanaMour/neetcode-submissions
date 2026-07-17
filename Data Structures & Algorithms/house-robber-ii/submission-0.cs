public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1)
            return nums[0];
        return Math.Max(RobHelp(nums, 0, nums.Length - 2), RobHelp(nums, 1, nums.Length - 1));
    }

    public int RobHelp(int[] nums, int start, int end) {
        int rob1 = 0;
        int rob2 = 0;

        for (int i = start; i <= end; i++) {
            int currentMax = Math.Max(nums[i] + rob1, rob2);

            rob1 = rob2;
            rob2 = currentMax;
        }

        return rob2;
    }
}
