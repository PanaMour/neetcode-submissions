/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        if (intervals == null || intervals.Count == 0) return true;
        intervals.Sort((a, b) => a.start.CompareTo(b.start));
        int currentEnd = intervals[0].end;
        for(int i = 1;i<intervals.Count;i++){
            int nextInterval = intervals[i].start;
            if(currentEnd > nextInterval) return false;
            else currentEnd = intervals[i].end;
        }
        return true;
    }
}
