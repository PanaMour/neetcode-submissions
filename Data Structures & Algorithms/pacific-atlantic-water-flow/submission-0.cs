public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        int rows = heights.Length;
        int cols = heights[0].Length;
        bool[,] pacific = new bool[rows, cols];
        bool[,] atlantic = new bool[rows, cols];
        List<List<int>> res = new List<List<int>>();
        for (int r = 0; r < rows; r++) {
            DFS(r, 0, heights, pacific, heights[r][0]);
            DFS(r, cols - 1, heights, atlantic, heights[r][cols - 1]);
        }
        for (int c = 0; c < cols; c++) {
            DFS(0, c, heights, pacific, heights[0][c]);
            DFS(rows - 1, c, heights, atlantic, heights[rows - 1][c]);
        }

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (pacific[i, j] == true && atlantic[i, j] == true) {
                    res.Add(new List<int> { i, j });
                }
            }
        }
        return res;
    }
    private void DFS(int r, int c, int[][] heights, bool[,] reachable, int prevHeight) {
        if (r < 0 || c < 0 || r >= heights.Length || c >= heights[0].Length ||
            reachable[r, c] == true || heights[r][c] < prevHeight) {
            return;
        }
        reachable[r, c] = true;
        DFS(r + 1, c, heights, reachable, heights[r][c]);
        DFS(r - 1, c, heights, reachable, heights[r][c]);
        DFS(r, c + 1, heights, reachable, heights[r][c]);
        DFS(r, c - 1, heights, reachable, heights[r][c]);
        return;
    }
}
