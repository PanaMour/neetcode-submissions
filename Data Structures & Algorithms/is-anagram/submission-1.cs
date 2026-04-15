public class Solution {
    public bool IsAnagram(string s, string t)
{
    var list = new List<char>();
    foreach (char x in s)
    {
        list.Add(x);
    }
    foreach (char x in t)
    {
        if (list.Contains(x))
        {
            list.Remove(x);
        }
        else list.Add(x);
    }
    if(list.Count == 0) return true;
    return false;
}
}
