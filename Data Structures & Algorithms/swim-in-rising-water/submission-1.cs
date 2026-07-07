public class Solution {
    public int SwimInWater(int[][] grid) {
        PriorityQueue<(int r, int c), int> pq = new PriorityQueue<(int r, int c), int>();
        pq.Enqueue((0, 0), grid[0][0]);
        int n = grid.Length;
        bool[,] visited = new bool[n, n];
        visited[0, 0] = true;
        int[][] dirs = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 },
                                     new int[] { -1, 0 } };
        while (pq.Count > 0) {
            pq.TryDequeue(out var element, out int currentTime);
            int r = element.r;
            int c = element.c;
            if (r == n - 1 && c == n - 1) {
                return currentTime;
            }
            foreach (var dir in dirs) {
                int newR = r + dir[0];
                int newC = c + dir[1];
                if (newR >= 0 && newR < n && newC >= 0 && newC < n && !visited[newR, newC]) {
                    visited[newR, newC] = true;
                    int nextTime = Math.Max(currentTime, grid[newR][newC]);
                    pq.Enqueue((newR, newC), nextTime);
                }
            }
        }

        return 0;
    }
}
