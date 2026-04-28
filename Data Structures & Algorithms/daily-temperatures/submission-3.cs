public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
{
    int[] res = new int[temperatures.Length];
    var stack = new Stack<int>();

    for (int i = 0; i < temperatures.Length; i++)
    {
        while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
        {
            int prevDay = stack.Pop();
            res[prevDay] = i - prevDay;
        }
        stack.Push(i);
    }
    return res;
}
}
