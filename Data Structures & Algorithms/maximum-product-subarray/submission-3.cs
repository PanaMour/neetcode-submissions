public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums.Length == 0)
            return 0;

        int currentMax = nums[0];
        int currentMin = nums[0];
        int globalMax = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            int num = nums[i];
            int tempMax = currentMax * num;
            currentMax = Math.Max(num, Math.Max(tempMax, currentMin * num));
            currentMin = Math.Min(num, Math.Min(tempMax, currentMin * num));
            globalMax = Math.Max(globalMax, currentMax);
        }

        return globalMax;
    }
}
