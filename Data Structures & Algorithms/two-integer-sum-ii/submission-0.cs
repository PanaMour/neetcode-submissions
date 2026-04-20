public class Solution {
    public int[] TwoSum(int[] numbers, int target)
{
    var map = new Dictionary<int, int>();
    int left = 0;
    int right = numbers.Length - 1;
    while (left < right)
    {
        if (numbers[left] + numbers[right] > target)
        {
            right--;
        }
        else if (numbers[left] + numbers[right] < target)
        {
            left++;
        }
        else
        {
            return new int[] { left+1, right+1 };
        }            
    }
    return new int[0];
}
}
