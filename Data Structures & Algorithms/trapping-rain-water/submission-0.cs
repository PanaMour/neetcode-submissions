public class Solution {
    public int Trap(int[] height)
{
    int sum = 0;
    
    for (int i = 1;i < height.Length; i++)
    {
        int prefMax = 0;
        int sufMax = 0;
        for (int l = 0; l < i; l++)
        {
            if (prefMax < height[l])
            {
                prefMax = height[l];
            }
        }
        for (int r = i+1; r < height.Length; r++)
        {
            if (sufMax < height[r])
            {
                sufMax = height[r];
            }
        }
        
        if(Math.Min(prefMax, sufMax) > height[i])
        {
            sum += Math.Min(prefMax, sufMax) - height[i];
        }

    }
    return sum;
}
}
