public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        int removed = 0;
        int currentEnd = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {
            int[] nextInterval = intervals[i];
            if(nextInterval[0] < currentEnd){
                removed++;
                currentEnd = Math.Min(currentEnd, nextInterval[1]);
            }
            else if (nextInterval[0] >= currentEnd){
                currentEnd = nextInterval[1];
            }
        }
        return removed;
    }
}
