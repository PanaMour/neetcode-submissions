public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1) {
                    max = Math.Max(max, DFS(grid, i, j, 0));
                }
            }
        }

        return max;
    }

    public int DFS(int[][] grid, int r, int c, int area) {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == 0) {
            return 0;
        }
        grid[r][c] = 0;
        return DFS(grid, r + 1, c, area) + DFS(grid, r - 1, c, area) + DFS(grid, r, c + 1, area) +
               DFS(grid, r, c - 1, area) + 1;
    }
}
