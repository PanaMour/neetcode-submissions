public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        int[] prices = new int[n];
        Array.Fill(prices, int.MaxValue);
        prices[src] = 0;

        for (int i = 0; i <= k; i++) {
            int[] tmpPrices = (int[])prices.Clone();
            foreach (var ticket in flights) {
                int u = ticket[0];
                int v = ticket[1];
                int flightCost = ticket[2];

                if (prices[u] == int.MaxValue)
                    continue;
                int totalCostToNextCity = prices[u] + flightCost;

                if (totalCostToNextCity < tmpPrices[v]) {
                    tmpPrices[v] = totalCostToNextCity;
                }
            }
            prices = tmpPrices;
        }

        if (prices[dst] == int.MaxValue)
            return -1;
        else
            return prices[dst];
    }
}
