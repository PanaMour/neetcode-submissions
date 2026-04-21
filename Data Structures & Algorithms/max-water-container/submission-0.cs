public class Solution {
    public int MaxArea(int[] heights)
{
    int left = 0;
    int right = heights.Length - 1;
    int sum = 0;
    while (left < right)
    {
        if (heights[left] <= heights[right])
        {                
            sum = Math.Max(sum,Math.Min(heights[left], heights[right]) * (right-left));
            left++;
        }
        else if (heights[left] > heights[right])
        {
            sum = Math.Max(sum, Math.Min(heights[left], heights[right]) * (right - left));
            right--;
        }
    }

    return sum;
}
}
