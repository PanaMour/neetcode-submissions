public class Solution {
    public int EvalRPN(string[] tokens)
{
    var st = new Stack<int>();
    foreach (string s in tokens)
    {
        if(int.TryParse(s, out int result))
        {
            Console.WriteLine(st.Count + s);
            st.Push(result);
        }
        else
        {
            switch (s)
            {
                case "+":
                    int i = st.Pop();
                    st.Push(st.Pop() + i);
                    break;
                case "-":
                    int j = st.Pop();
                    st.Push(st.Pop() - j);
                    break;
                case "*":
                    int x = st.Pop();
                    st.Push(st.Pop() * x);
                    break;
                case "/":
                    int t = st.Pop();
                    st.Push(st.Pop() / t);
                    break;
            }
        }
    }

    return st.Pop();
}
}
