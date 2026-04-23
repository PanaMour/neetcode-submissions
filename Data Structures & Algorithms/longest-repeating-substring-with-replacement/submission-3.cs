public class Solution {
    public int CharacterReplacement(string s, int k) {
        var chars = new Dictionary<char, int>();
int left = 0;
int best = 0;
int maxFreq = 0;
for (int right = 0; right < s.Length; right++)
{
    if (!chars.ContainsKey(s[right]))
    {
        chars.Add(s[right], 0);
    }
    chars[s[right]]++;
    maxFreq = Math.Max(maxFreq, chars[s[right]]);
    while ((right - left + 1) - maxFreq > k)
    {
        chars[s[left]]--;
        left++;
    }

    best = Math.Max(best, right - left + 1);
}

return best;
    }
}
