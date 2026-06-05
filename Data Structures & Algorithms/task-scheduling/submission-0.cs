public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var count = new Dictionary<char, int>();
        foreach (char task in tasks) {
            if (count.ContainsKey(task))
                count[task]++;
            else
                count[task] = 1;
        }
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        foreach (var value in count.Values) {
            maxHeap.Enqueue(value, -value);
        }
        Queue<(int frequency, int availableTime)> queue =
            new Queue<(int frequency, int availableTime)>();
        int time = 0;
        while (maxHeap.Count > 0 || queue.Count > 0) {
            time++;
            if (maxHeap.Count > 0) {
                int currentFreq = maxHeap.Dequeue() - 1;

                if (currentFreq > 0) {
                    queue.Enqueue((currentFreq, time + n));
                }
            }

            if (queue.Count > 0 && queue.Peek().availableTime == time) {
                int returningFreq = queue.Dequeue().frequency;
                maxHeap.Enqueue(returningFreq, -returningFreq);
            }
        }
        return time;
    }
}
