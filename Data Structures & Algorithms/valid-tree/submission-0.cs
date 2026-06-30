public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != n - 1) {
            return false;
        }

        List<int>[] adj = new List<int>[n];
        for (int i = 0; i < n; i++) {
            adj[i] = new List<int>();
        }

        for (int i = 0; i < edges.Length; i++) {
            int u = edges[i][0];
            int v = edges[i][1];
            adj[u].Add(v);
            adj[v].Add(u);
        }

        HashSet<int> visited = new HashSet<int>();
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(0);
        visited.Add(0);

        while (queue.Count > 0) {
            int current = queue.Dequeue();

            foreach (int neighbor in adj[current]) {
                if (!visited.Contains(neighbor)) {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        return visited.Count == n;
    }
}
