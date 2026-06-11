public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();
        Backtrack(nums, current, result);

        return result;
    }

    private void Backtrack(int[] nums, List<int> current, List<List<int>> result) {
        if (current.Count == nums.Length) {
            result.Add(new List<int>(current));
            return;
        }
        for (int i = 0; i < nums.Length; i++) {
            if (current.Contains(nums[i])) {
                continue;
            }
            current.Add(nums[i]);
            Backtrack(nums, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
