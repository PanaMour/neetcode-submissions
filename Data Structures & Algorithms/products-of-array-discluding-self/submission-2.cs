public class Solution {
    public int[] ProductExceptSelf(int[] nums)
{
    int[] res = new int[nums.Length];
    int left = 1;
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = left;
        left = left * nums[i];
    }
    int right = 1;
    for (int i=nums.Length-1; i >= 0; i--)
    {
        res[i] *= right;
        right = right * nums[i];
    }
    return res;
}
}
