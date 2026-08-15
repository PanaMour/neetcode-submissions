public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalSurplus = 0;
        int currentSurplus = 0;
        int startStation = 0;
        for (int i = 0; i < gas.Length; i++) {
            int net = gas[i] - cost[i];
            totalSurplus += net;
            currentSurplus += net;
            if (currentSurplus < 0) {
                startStation = i + 1;
                currentSurplus = 0;
            }
        }

        if (totalSurplus < 0)
            return -1;
        else
            return startStation;
    }
}
