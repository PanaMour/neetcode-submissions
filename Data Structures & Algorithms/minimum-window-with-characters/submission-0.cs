public class Solution {
    public string MinWindow(string s, string t)
{
    if (t.Length > s.Length || string.IsNullOrEmpty(t)) return "";

    var countT = new Dictionary<char, int>();
    var window = new Dictionary<char, int>();
    
    foreach (char c in t)
    {
        if (!countT.ContainsKey(c)) countT[c] = 0;
        countT[c]++;
    }

    int have = 0;
    int need = countT.Count;

    int resStart = -1;
    int resLen = int.MaxValue;
    int left = 0;

    for (int right = 0; right < s.Length; right++)
    {
        char c = s[right];
        if (!window.ContainsKey(c)) window[c] = 0;
        window[c]++;

        if (countT.ContainsKey(c) && window[c] == countT[c])
        {
            have++;
        }

        while (have == need)
        {
            int currentWindowSize = right - left + 1;
            if (currentWindowSize < resLen)
            {
                resStart = left;
                resLen = currentWindowSize;
            }

            char leftChar = s[left];
            window[leftChar]--;

            if (countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar])
            {
                have--;
            }
            
            left++;
        }
    }

    return resLen == int.MaxValue ? "" : s.Substring(resStart, resLen);
}
}
