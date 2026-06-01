public class KthLargest
{
    private int k;
    PriorityQueue<int, int> minheap;
    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        this.minheap = new PriorityQueue<int, int>();

        foreach(int num in nums)
        {
            Add(num);
        }
    }

    public int Add(int val)
    {
        minheap.Enqueue(val, val);

        if(minheap.Count > k)
        {
            minheap.Dequeue();
        }

        return minheap.Peek();
    }
}