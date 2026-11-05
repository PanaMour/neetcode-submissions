public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new List<int[]>();
        bool inserted = false;

        for (int i = 0; i < intervals.Length; i++) {
            if (intervals[i][1] < newInterval[0]) {
                result.Add(intervals[i]);
            } else if (intervals[i][0] > newInterval[1]) {
                if (!inserted) {
                    result.Add(newInterval);
                    inserted = true;
                }
                result.Add(intervals[i]);
            } else {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            }
        }

        if (!inserted) {
            result.Add(newInterval);
        }

        return result.ToArray();
    }
}
