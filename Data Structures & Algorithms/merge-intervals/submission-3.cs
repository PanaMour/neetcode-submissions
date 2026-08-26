public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result = new List<int[]>();
        result.Add(intervals[0]);
        int[] activeInterval = intervals[0];
        foreach(int[] nextInterval in intervals){
            if( nextInterval[0] <= activeInterval[1]){
                activeInterval[1] = Math.Max(activeInterval[1], nextInterval[1]);
            }else {
                result.Add(nextInterval);
                activeInterval = nextInterval;
            }
        }
        return result.ToArray();
    }
}
