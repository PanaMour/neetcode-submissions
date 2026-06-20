public class Solution {
    public int NumIslands(char[][] grid) {
        int sum = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == '1') {
                    sum++;
                    DFS(grid, i, j);
                }
            }
        }

        return sum;
    }

    public void DFS(char[][] grid, int r, int c) {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == '0') {
            return;
        }
        grid[r][c] = '0';
        DFS(grid, r + 1, c);
        DFS(grid, r - 1, c);
        DFS(grid, r, c + 1);
        DFS(grid, r, c - 1);
    }
}
