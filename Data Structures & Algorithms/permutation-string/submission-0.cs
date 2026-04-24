public class Solution {
    public bool CheckInclusion(string s1, string s2)
{
    if (s1.Length > s2.Length) return false;

    var c1= s1.ToCharArray();
    Array.Sort(c1);
    int left = 0;
    for(int right= 0; right < s2.Length; right++)
    {
        if(right-left+1 == s1.Length)
        {
            
            char[] c2 = s2.Substring(left, s1.Length).ToCharArray();
            Array.Sort(c2);
            Console.WriteLine(left + "  " + right + " " + c2.Length);
            if (c1.SequenceEqual(c2)) { return true; }
            else
            {
                left++;
            }
        }
    }

    return false;
}
}
