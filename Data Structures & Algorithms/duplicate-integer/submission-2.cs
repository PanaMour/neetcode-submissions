public class Solution {
    public bool hasDuplicate(int[] nums)
{
    var set = new HashSet<int>();
    foreach (int x in nums)
    {
        if (!set.Contains(x))
        {
            set.Add(x);
        }
        else
        {
            return true;
        }
    }
    return false;
}
}