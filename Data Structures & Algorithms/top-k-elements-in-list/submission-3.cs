public class Solution {
public int[] TopKFrequent(int[] nums, int k)
{
    var freq = new Dictionary<int, int>();
    
    foreach (int i in nums)
    {
        if (freq.ContainsKey(i))
        {
            freq[i]++;
        }
        else
        {
            freq[i] = 1;
        }
    }
    var list = new List<int>();        
    for (int i = 0; i< k; i++)
    {
        int maxFreq = 0;
        int maxVal = 0;
        foreach (int j in freq.Keys)
        {
            if(freq[j] >= maxFreq)
            {
                maxFreq = freq[j];
                maxVal = j;
            }
        }
        list.Add(maxVal);
        freq.Remove(maxVal);
    }
    if (!list.Any()) return [];
    return list.ToArray();
}
}
