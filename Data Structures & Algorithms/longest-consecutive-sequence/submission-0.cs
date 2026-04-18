public class Solution {
    public int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0) return 0;
    int[] sorted = nums.Distinct().OrderBy(x => x).ToArray();
    int seqMax = 1;
    int tempMax = 1;
    for (int i = 1;i< sorted.Length;i++)
    {
        if (sorted[i] == sorted[i-1]+1)
        {
            tempMax++;
            if(seqMax < tempMax)
            {
                seqMax = tempMax;
            }
        }
        else
        {
            tempMax = 1;
        }
    }
    return seqMax;
}
}
