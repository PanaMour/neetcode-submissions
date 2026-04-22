public class Solution {
    public int MaxProfit(int[] prices)
{
    int minPrice = int.MaxValue;
    int profit = 0;
    int res = 0;
    for (int i = 0; i < prices.Length; i++)
    {
        res = Math.Max(res, prices[i] - minPrice);
        minPrice = Math.Min(minPrice, prices[i]);
        res = Math.Max(res, profit);            
    }
    return res;
}
}
