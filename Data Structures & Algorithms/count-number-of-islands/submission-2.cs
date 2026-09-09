public class Solution {
    public int NumIslands(char[][] grid) {
        int count = 0;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(grid[i][j] == '1'){
                    DFS(grid,i,j);
                    count++;
                }
            }
        }
        return count;
    }

    private void DFS(char[][] grid, int i, int j){
        if(i>=grid.Length || i<0 || j>=grid[0].Length || j<0 || grid[i][j] == '0' ) return;
        else if (grid[i][j] == '1'){
            grid[i][j] = '0';
            DFS(grid,i+1,j);
            DFS(grid,i-1,j);
            DFS(grid,i,j+1);
            DFS(grid,i,j-1);
        }
    }
}
