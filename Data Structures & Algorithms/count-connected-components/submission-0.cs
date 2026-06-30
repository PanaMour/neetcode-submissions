public class Solution {
    public int CountComponents(int n, int[][] edges) {
        List<int>[] adj = new List<int>[n];
        for (int i = 0; i < n; i++) {
            adj[i] = new List<int>();
        }
        for (int i = 0; i < edges.Length; i++) {
            adj[edges[i][1]].Add(edges[i][0]);
            adj[edges[i][0]].Add(edges[i][1]);
        }
        HashSet<int> visited = new HashSet<int>();
        Queue<int> queue = new Queue<int>();
        int graphs = 0;
        for (int node = 0; node < n; node++) {
            if (visited.Contains(node))
                continue;
            graphs++;
            queue.Enqueue(node);
            visited.Add(node);
            while (queue.Count > 0) {
                int current = queue.Dequeue();
                foreach (int neighbor in adj[current]) {
                    if (!visited.Contains(neighbor)) {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
        return graphs;
    }
}
