public class Solution {
    public int MaxCoins(int[] nums) {
        int[] padded = new int[nums.Length + 2];
        padded[0] = 1;
        padded[padded.Length - 1] = 1;
        for (int i = 0; i < nums.Length; i++) {
            padded[i + 1] = nums[i];
        }
        int[,] memo = new int[padded.Length, padded.Length];
        return DFS(padded, 0, padded.Length - 1, memo);
    }

    int DFS(int[] padded, int left, int right, int[,] memo) {
        if (left + 1 == right)
            return 0;
        if (memo[left, right] > 0)
            return memo[left, right];
        int maxCoins = 0;
        for (int i = left + 1; i <= right - 1; i++) {
            int coins = padded[left] * padded[i] * padded[right] + DFS(padded, left, i, memo) +
                        DFS(padded, i, right, memo);
            maxCoins = Math.Max(maxCoins, coins);
            memo[left, right] = maxCoins;
        }

        return memo[left, right];
    }
}
