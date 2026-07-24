public class Solution {
    private int IsPalindrome(string s, int left, int right) {
        int count = 0;
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            count++;
            left--;
            right++;
        }

        return count;
    }

    public int CountSubstrings(string s) {
        if (string.IsNullOrEmpty(s))
            return 0;
        int sum = 0;

        for (int i = 0; i < s.Length; i++) {
            sum += IsPalindrome(s, i, i);
            sum += IsPalindrome(s, i, i + 1);
        }

        return sum;
    }
}
