public class Solution {
    public bool IsValidSudoku(char[][] board)
{
    HashSet<string> seen = new HashSet<string>();

    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            char number = board[i][j];
            Console.WriteLine(i + " " + j);
            if (number != '.')
            {
                if (!seen.Add(number + " in row " + i) ||
                    !seen.Add(number + " in col " + j) ||
                    !seen.Add(number + " in box " + i / 3 + "-" + j / 3))
                {
                    return false;
                }
            }
        }
    }

    return true;
}
}
