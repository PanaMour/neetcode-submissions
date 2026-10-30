public class Solution {

    public string Encode(IList<string> strs)
{
    StringBuilder enc = new StringBuilder();
    foreach (string str in strs)
    {
            enc.Append(str.Length + "#" + str);
    }

    return enc.ToString();
}

public List<string> Decode(string s)
{
    var dec = new List<string>();
    int i = 0;

    while (i < s.Length)
    {
        int j = i;
        while (s[j] != '#')
        {
            j += 1;
            
        }
        int len = Int32.Parse(s[i..j]);
        int wordStart = j + 1;
        int wordEnd = wordStart + len;
        dec.Add(s[wordStart..wordEnd]);
        i = wordEnd;
    }
    return dec;
}
}
