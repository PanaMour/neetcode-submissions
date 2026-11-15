public class Solution {
    public int MaxProfit(int[] prices)
{
    int minPrice = int.MaxValue;
    int res = 0;
    for (int i = 0; i < prices.Length; i++)
    {
        int profit = prices[i] - minPrice;
        minPrice = Math.Min(minPrice, prices[i]);
        res = Math.Max(res, profit);            
    }
    return res;
}
}
