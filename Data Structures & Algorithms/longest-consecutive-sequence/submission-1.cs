public class Solution {
    public int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0) return 0;

    var set = new HashSet<int>(nums);
    int seqMax = 1;
    foreach(int num in set)
    {
        if (!set.Contains(num-1))
        {
            int j = 1;
            while (set.Contains(num + j)){
                j++;
            }
            if(seqMax < j)
            {
                seqMax = j;
            }
        }
    }
    return seqMax;
}
}
