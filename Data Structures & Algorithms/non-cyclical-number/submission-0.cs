public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> visited = new HashSet<int>();
        while (n != 1 && !visited.Contains(n)) {
            visited.Add(n);
            n = GetSumOfSquares(n);
        }
        return n == 1;
    }
    private int GetSumOfSquares(int n) {
        int sum = 0;
        while (n > 0) {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
}
