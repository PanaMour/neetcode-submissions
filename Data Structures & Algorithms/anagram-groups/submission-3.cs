public class Solution {
     public List<List<string>> GroupAnagrams(string[] strs)
{
    var groups = new Dictionary<string, List<string>>();

    foreach (string str in strs)
    {
        char[] chars = str.ToCharArray();
        Array.Sort (chars);
        string key = new string(chars);

        if (!groups.ContainsKey(key))
        {
            groups[key] = new List<string>();
        }
        groups[key].Add(str);
    }
    return groups.Values.ToList();
}
}