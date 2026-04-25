public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k)
{
    if (nums == null || nums.Length == 0) return new int[0];

    int[] res = new int[nums.Length - k + 1];
    int resIndex = 0;

    var deque = new LinkedList<int>();

    for(int i =0;i < nums.Length;i++)
    {
        if(deque.Count > 0  && deque.First.Value < i - k + 1)
        {
            deque.RemoveFirst();
        }

        while(deque.Count > 0 && nums[deque.Last.Value] < nums[i])
        {
            deque.RemoveLast();
        }

        deque.AddLast(i);

        if( i >= k - 1)
        {
            res[resIndex] = nums[deque.First.Value];
            resIndex++;
        }
    }

    return res;
}
}
