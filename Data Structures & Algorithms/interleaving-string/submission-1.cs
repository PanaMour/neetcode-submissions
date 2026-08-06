public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s3.Length != (s1.Length + s2.Length))
            return false;
        bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[0, 0] = true;

        for (int i = 1; i <= s1.Length; i++) {
            if (s3[i - 1] == s1[i - 1] && dp[i - 1, 0] == true) {
                dp[i, 0] = true;
            }
        }
        for (int j = 1; j <= s2.Length; j++) {
            if (s3[j - 1] == s2[j - 1] && dp[0, j - 1] == true) {
                dp[0, j] = true;
            }
        }
        for (int i = 1; i <= s1.Length; i++) {
            for (int j = 1; j <= s2.Length; j++) {
                if ((dp[i - 1, j] == true && s1[i - 1] == s3[i + j - 1]) ||
                    (dp[i, j - 1] == true && s2[j - 1] == s3[i + j - 1])) {
                    dp[i, j] = true;
                }
            }
        }
        return dp[s1.Length, s2.Length];
    }
}
