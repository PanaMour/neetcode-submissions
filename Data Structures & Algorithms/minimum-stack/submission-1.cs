public class MinStack
{
    Stack<int> mst = new Stack<int>();
    Stack<int> minst;
    public MinStack()
    {
        minst = new Stack<int>();
    }

    public void Push(int val)
    {
        mst.Push(val);
        if (minst.Count() == 0)
        {
            minst.Push(val);
        }
        else if (val <= minst.Peek())
        {
            minst.Push(val);
        }
    }

    public void Pop()
    {
        int top = mst.Pop();
        if (minst.Peek() == top)
        {
            minst.Pop();
        }
    }

    public int Top()
    {

        return mst.Peek();
    }

    public int GetMin()
    {

        return minst.Peek();
    }
}
