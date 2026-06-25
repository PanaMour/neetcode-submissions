public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<((int r, int c), int m)> queue = new Queue<((int r, int c), int m)>();
        int minutes = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 2) {
                    queue.Enqueue(((i, j), 0));
                }
            }
        }

        int[][] dirs = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 },
                                     new int[] { 0, -1 } };
        while (queue.Count > 0) {
            var current = queue.Dequeue();
            int r = current.Item1.r;
            int c = current.Item1.c;
            minutes = current.m;

            foreach (var dir in dirs) {
                int nextR = r + dir[0];
                int nextC = c + dir[1];
                if (nextR < 0 || nextC < 0 || nextR >= grid.Length || nextC >= grid[0].Length) {
                    continue;
                }

                if (grid[nextR][nextC] != 1) {
                    continue;
                }
                Console.WriteLine(nextR + " " + nextC);
                grid[nextR][nextC] = grid[r][c] + 1;
                queue.Enqueue(((nextR, nextC), minutes + 1));
            }
        }
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1) {
                    return -1;
                }
            }
        }

        return minutes;
    }
}
