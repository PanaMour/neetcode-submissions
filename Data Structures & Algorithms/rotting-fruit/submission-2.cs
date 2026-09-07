public class Solution {
    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int freshFruit = 0;
        Queue<(int r, int c)> queue = new Queue<(int r, int c)>();
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 1)
                    freshFruit++;
                else if (grid[i][j] == 2)
                    queue.Enqueue((i, j));
            }
        }
        if (freshFruit == 0)
            return 0;

        int minutes = 0;
        while (queue.Count > 0 && freshFruit > 0) {
            minutes++;
            int levelSize = queue.Count();
            for (int i = 0; i < levelSize; i++) {
                var current = queue.Dequeue();
                int r = current.r;
                int c = current.c;

                if (r + 1 < rows && grid[r + 1][c] == 1) {
                    grid[r + 1][c] = 2;
                    freshFruit--;
                    queue.Enqueue((r + 1, c));
                }
                if (r - 1 >= 0 && grid[r - 1][c] == 1) {
                    grid[r - 1][c] = 2;
                    freshFruit--;
                    queue.Enqueue((r - 1, c));
                }
                if (c + 1 < cols && grid[r][c + 1] == 1) {
                    grid[r][c + 1] = 2;
                    freshFruit--;
                    queue.Enqueue((r, c + 1));
                }

                if (c - 1 >= 0 && grid[r][c - 1] == 1) {
                    grid[r][c - 1] = 2;
                    freshFruit--;
                    queue.Enqueue((r, c - 1));
                }
            }
        }
        return freshFruit == 0 ? minutes : -1;
    }
}
