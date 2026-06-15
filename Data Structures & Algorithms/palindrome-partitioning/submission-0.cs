public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> result = new List<List<string>>();
        List<string> current = new List<string>();
        Backtrack(0, s, current, result);
        return result;
    }

    public void Backtrack(int start, string s, List<string> current, List<List<string>> result) {
        if (start == s.Length) {
            result.Add(new List<string>(current));
        }
        for (int end = start; end < s.Length; end++) {
            if (!IsPalindrome(s, start, end))
                continue;
            current.Add(s.Substring(start, end - start + 1));
            Backtrack(end + 1, s, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }

    private bool IsPalindrome(string s, int left, int right) {
        while (s[left] == s[right] && left < right) {
            left++;
            right--;
        }
        return left >= right;
    }
}
