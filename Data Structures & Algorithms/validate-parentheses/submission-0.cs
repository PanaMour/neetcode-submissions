public class Solution {
    public bool IsValid(string s)
{
    var st = new Stack<char>();
    foreach(char c in s)
    {
        switch(c)
        {
            case '(':
                st.Push(')');
                break;
            case '{':
                st.Push('}');
                break;
            case '[':
                st.Push(']');
                break;
            default:
                if(st.Count() == 0 || st.Pop() != c)
                {
                    return false;
                }
                break;
        }
    }
    return st.Count() == 0;
}
}
