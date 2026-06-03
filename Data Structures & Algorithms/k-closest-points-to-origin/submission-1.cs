public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> maxHeap = new PriorityQueue<int[], int>();

        foreach (int[] point in points) {
            int distance = (point[0] * point[0]) + (point[1] * point[1]);

            maxHeap.Enqueue(point, -distance);

            if (maxHeap.Count > k) {
                maxHeap.Dequeue();
            }
        }

        int[][] result = new int [k][];
        for (int i = 0; i < k; i++) {
            result[i] = maxHeap.Dequeue();
        }

        return result;
    }
}
