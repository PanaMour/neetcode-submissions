public class Solution {
    public int[] FindRedundantConnection(int[][] edges) 
    {
        int n = edges.Length;
        int[] parent = new int[n + 1];
        for (int i = 1; i <= n; i++) 
        {
            parent[i] = i;
        }
        
        foreach (var edge in edges) 
        {
            int u = edge[0];
            int v = edge[1];
            
            int rootU = Find(u, parent);
            int rootV = Find(v, parent);            
            if (rootU == rootV) 
            {
                return edge; 
            }
            parent[rootV] = rootU;
        }
        
        return new int[0];
    }
    
    private int Find(int node, int[] parent) 
    {
        if (parent[node] == node) 
        {
            return node;
        }
        parent[node] = Find(parent[node], parent);
        
        return parent[node];
    }
}
