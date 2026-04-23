public class Solution {
    public int LengthOfLongestSubstring(string s)
{
    var set = new HashSet<char>();
    int left = 0;
    int right = 0;
    int maxL = 0;
    while(right < s.Length)
    {
        if (!set.Contains(s[right]))
        {
            set.Add(s[right]);
            right++;
        }
        else
        {                
            set.Remove(s[left]);
            left++;
        }
        maxL = Math.Max(maxL, right - left);
    }        
    
    return maxL;
}
}
