public class Solution {
    public List<string> LetterCombinations(string digits) {
        if (digits == "")
            return new List<string>();
        List<string> result = new List<string>();
        Backtrack(0, digits, "", result);

        return result;
    }

    public void Backtrack(int i, string digits, string current, List<string> result) {
        string[] keypad =
            new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        if (i == digits.Length) {
            result.Add(current);
            return;
        }
        int index = digits[i] - '0';
        string letters = keypad[index];
        foreach (char c in letters) {
            Backtrack(i + 1, digits, current + c, result);
        }
    }
}
