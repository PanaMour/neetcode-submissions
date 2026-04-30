public class Solution {
   public int CarFleet(int target, int[] position, int[] speed)
{
    var pairs = new (int pos, int spd)[position.Length];
    for (int i = 0; i < position.Length; i++)
    {
        pairs[i] = (position[i], speed[i]);
    }
    Array.Sort(pairs, (a, b) => b.pos.CompareTo(a.pos));
    var stack = new Stack<double>();
    foreach(var pair in pairs)
    {
        double time = (double)(target - pair.pos) / pair.spd;
        if (stack.Count == 0 || time > stack.Peek())
        {
            stack.Push(time);
        }
    }

    return stack.Count();
}
}
