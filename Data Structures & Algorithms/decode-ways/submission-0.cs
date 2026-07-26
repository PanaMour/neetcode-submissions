public class Solution {
    public int NumDecodings(string s) {
        int[] dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = s[0] == '0' ? 0 : 1;
        for (int i = 2; i <= s.Length; i++) {
            if (s[i - 1] != '0') {
                dp[i] += dp[i - 1];
            }
            int twoDigit = Int32.Parse(s.Substring(i - 2, 2));
            if (twoDigit >= 10 && twoDigit <= 26) {
                dp[i] += dp[i - 2];
            }
        }
        return dp[s.Length];
    }
}
