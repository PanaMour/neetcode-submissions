public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        PriorityQueue<(int node, int cost), int> pq =
            new PriorityQueue<(int node, int cost), int>();
        pq.Enqueue((0, 0), 0);
        HashSet<int> visited = new HashSet<int>();
        int totalCost = 0;
        while (visited.Count < points.Length) {
            pq.TryDequeue(out var element, out int currentCost);
            int currentNode = element.node;
            if (visited.Contains(currentNode))
                continue;
            else {
                visited.Add(currentNode);
                totalCost += currentCost;
            }
            for (int nextNode = 0; nextNode < points.Length; nextNode++) {
                if (!visited.Contains(nextNode)) {
                    int distance = Math.Abs(points[currentNode][0] - points[nextNode][0]) +
                                   Math.Abs(points[currentNode][1] - points[nextNode][1]);

                    pq.Enqueue((nextNode, distance), distance);
                }
            }
        }

        return totalCost;
    }
}
