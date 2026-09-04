public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;
        char[] sarray = s.ToCharArray();
        char[] tarray = t.ToCharArray();
        Array.Sort(sarray);
        Array.Sort(tarray);
        return sarray.SequenceEqual(tarray);
    }
}
