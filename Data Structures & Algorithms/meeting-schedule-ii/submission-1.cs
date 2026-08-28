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
    public int MinMeetingRooms(List<Interval> intervals) {
        if (intervals == null || intervals.Count == 0) return 0;
        int[] start = new int[intervals.Count];
        int[] end = new int[intervals.Count];
        for(int i=0;i<intervals.Count;i++){
            start[i] = intervals[i].start;
            end[i] = intervals[i].end;
        }
        Array.Sort(start);
        Array.Sort(end);
        int startPointer = 0, endPointer = 0;
        int currentRooms = 0, maxRooms = 0;
        
        while(startPointer < start.Length){
            if(start[startPointer] < end[endPointer]){
            currentRooms++;
            maxRooms = Math.Max(maxRooms,currentRooms);
            startPointer++;
            }
            else{
                currentRooms--;
                endPointer++;
            }
        }
        return maxRooms;
    }
}
