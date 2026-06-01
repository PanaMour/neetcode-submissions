public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        foreach (int stone in stones) {
            maxHeap.Enqueue(stone, -stone);
        }
        while (maxHeap.Count > 1) {
            int x = maxHeap.Dequeue();
            int y = maxHeap.Dequeue();
            if (y < x)
                maxHeap.Enqueue(x - y, y - x);
        }
        if (maxHeap.Count > 0)
            return maxHeap.Dequeue();
        return 0;
    }
}
