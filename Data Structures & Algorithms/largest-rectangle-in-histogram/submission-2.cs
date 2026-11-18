public class Solution {
    public int LargestRectangleArea(int[] heights)
{
    var stack = new Stack<(int index,int height)>();

    int maxArea = 0;
    for (int i = 0; i < heights.Length; i++)
    {
        int start = i;
        while (stack.Count > 0 && stack.Peek().height > heights[i])
        {
            var popped = stack.Pop();
            int currentArea = popped.height * (i - popped.index);
            maxArea = Math.Max(maxArea, currentArea);
            start = popped.index;
        }
        stack.Push((start, heights[i]));
    }
    while (stack.Count > 0)
    {
        var popped = stack.Pop();
        int currentArea = popped.height * (heights.Length - popped.index);
        maxArea = Math.Max(maxArea, currentArea);
    }
    return maxArea;
}
}
