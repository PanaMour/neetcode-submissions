public class Solution {
    public List<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        Backtrack(0, 0, n, "", result);
        return result;
    }
    private void Backtrack(int openCount, int closeCount, int n, string current,
                           List<string> result) {
        if (openCount == n && closeCount == n) {
            result.Add(current);
            return;
        }

        if (openCount < n) {
            Backtrack(openCount + 1, closeCount, n, current + "(", result);
        }
        if (closeCount < openCount) {
            Backtrack(openCount, closeCount + 1, n, current + ")", result);
        }
    }
}
