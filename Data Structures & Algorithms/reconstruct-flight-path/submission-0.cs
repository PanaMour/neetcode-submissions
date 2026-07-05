public class Solution {
    public List<string> FindItinerary(List<List<string>> tickets) {
        Dictionary<string, PriorityQueue<string, string>> adj =
            new Dictionary<string, PriorityQueue<string, string>>();
        List<string> res = new List<string>();
        foreach (var ticket in tickets) {
            string from = ticket[0];
            string to = ticket[1];

            if (!adj.ContainsKey(from)) {
                adj[from] = new PriorityQueue<string, string>();
            }
            adj[from].Enqueue(to, to);
        }
        DFS("JFK", adj, res);
        res.Reverse();
        return res;
    }

    private void DFS(string airport, Dictionary<string, PriorityQueue<string, string>> adj,
                     List<string> res) {
        while (adj.ContainsKey(airport) && adj[airport].Count > 0) {
            string next = adj[airport].Dequeue();
            DFS(next, adj, res);
        }
        res.Add(airport);
    }
}
