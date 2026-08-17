public class Solution {
    public List<int> PartitionLabels(string s) {
        Dictionary<char, (int start, int end)> dict = new Dictionary<char, (int start, int end)>();
        for (int i = 0; i < s.Length; i++) {
            if (!dict.ContainsKey(s[i]))
                dict[s[i]] = (i, i);
            else
                dict[s[i]] = (dict[s[i]].start, i);
        }
        List<int> result = new List<int>();
        int size = 0;
        int end = 0;
        for (int i = 0; i < s.Length; i++) {
            end = Math.Max(end, dict[s[i]].end);
            size++;
            if (i == end) {
                result.Add(size);
                size = 0;
            }
        }

        return result;
    }
}
