public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
{
    int[] res = new int[temperatures.Length];
    for(int i = 0; i < temperatures.Length-1; i++)
    {
        int j = i+1;
        while (temperatures[i] >= temperatures[j] && j < temperatures.Length-1)
        {
            j++;
        }
        if(temperatures[i] < temperatures[j])
        {
            res[i] = j - i;
        }
        else
        {
            res[i] = 0;
        }
        
    }
    res[temperatures.Length - 1] = 0;
    return res;
}
}
