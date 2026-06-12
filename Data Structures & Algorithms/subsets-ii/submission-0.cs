public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();
        Backtrack(0, nums, current, result);

        return result;
    }
    private void Backtrack(int i, int[] nums, List<int> current, List<List<int>> result) {
        if (i == nums.Length) {
            result.Add(new List<int>(current));
            return;
        }
        current.Add(nums[i]);
        Backtrack(i + 1, nums, current, result);
        current.RemoveAt(current.Count - 1);
        while (i + 1 < nums.Length && nums[i] == nums[i + 1]) i++;
        Backtrack(i + 1, nums, current, result);
    }
}
