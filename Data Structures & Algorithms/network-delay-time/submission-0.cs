public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        List<(int target, int weight)>[] adj = new List<(int, int)>[n + 1];
        for (int i = 1; i <= n; i++) {
            adj[i] = new List<(int, int)>();
        }
        for (int i = 0; i < times.Length; i++) {
            int u = times[i][0];
            int v = times[i][1];
            int w = times[i][2];
            adj[u].Add((v, w));
        }
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.Enqueue(k, 0);
        HashSet<int> visited = new HashSet<int>();
        int maxTime = 0;
        while (pq.Count > 0) {
            pq.TryDequeue(out int currentNode, out int currentTime);
            if (visited.Contains(currentNode))
                continue;
            visited.Add(currentNode);
            maxTime = Math.Max(maxTime, currentTime);
            foreach (var neighbor in adj[currentNode]) {
                int newTime = currentTime + neighbor.weight;
                pq.Enqueue(neighbor.target, newTime);
            }
        }
        return visited.Count == n ? maxTime : -1;
    }
}
