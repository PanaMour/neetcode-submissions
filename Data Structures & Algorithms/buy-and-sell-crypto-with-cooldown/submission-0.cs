public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1)
            return 0;

        int n = prices.Length;

        int[] hold = new int[n];
        int[] sold = new int[n];
        int[] rest = new int[n];
        hold[0] = -prices[0];
        sold[0] = 0;
        rest[0] = 0;
        for (int i = 1; i < n; i++) {
            hold[i] = Math.Max(hold[i - 1], rest[i - 1] - prices[i]);
            sold[i] = hold[i - 1] + prices[i];
            rest[i] = Math.Max(rest[i - 1], sold[i - 1]);
        }

        return Math.Max(sold[n - 1], rest[n - 1]);
    }
}
