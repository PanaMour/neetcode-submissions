public class Solution {
    public int Trap(int[] height)
{
    if(height.Length == 0) return 0;
    int maxLeft = height[0];
int maxRight = height[height.Length - 1];
int left = 0;
int right = height.Length-1;
int sum = 0;
while(left < right)
{
    if (maxLeft <= maxRight)
{
    left++;
    maxLeft = Math.Max(maxLeft, height[left]);
    sum += Math.Max(0, maxLeft - height[left]);
}
else if (maxLeft > maxRight)
{
    right--;
    sum += Math.Max(0,maxRight - height[right]);
    maxRight = Math.Max(maxRight, height[right]);                
}
}
    return sum;
}
}
