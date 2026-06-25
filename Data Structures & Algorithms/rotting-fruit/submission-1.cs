public class Solution {
    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        Queue<(int r, int c)> queue = new Queue<(int r, int c)>();
        int freshOranges = 0;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 2) {
                    queue.Enqueue((i, j));
                } else if (grid[i][j] == 1) {
                    freshOranges++;
                }
            }
        }
        if (freshOranges == 0)
            return 0;

        int minutes = 0;
        int[][] dirs = new int[][] {
            new int[] { 1, 0 },   // Down
            new int[] { -1, 0 },  // Up
            new int[] { 0, 1 },   // Right
            new int[] { 0, -1 }   // Left
        };

        while (queue.Count > 0 && freshOranges > 0) {
            minutes++;
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++) {
                var current = queue.Dequeue();
                int r = current.r;
                int c = current.c;

                foreach (var dir in dirs) {
                    int nextR = r + dir[0];
                    int nextC = c + dir[1];

                    if (nextR < 0 || nextC < 0 || nextR >= rows || nextC >= cols) {
                        continue;
                    }

                    if (grid[nextR][nextC] == 1) {
                        grid[nextR][nextC] = 2;
                        freshOranges--;
                        queue.Enqueue((nextR, nextC));
                    }
                }
            }
        }

        return freshOranges == 0 ? minutes : -1;
    }
}
