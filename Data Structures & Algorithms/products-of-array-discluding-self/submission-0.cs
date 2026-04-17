public class Solution {
    public int[] ProductExceptSelf(int[] nums)
{
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = 1;
        for (int j = 0;j < nums.Length; j++)
        {
            if(j != i)
            {
                res[i] *= nums[j];
            }
        }
    }
    return res;
}
}
