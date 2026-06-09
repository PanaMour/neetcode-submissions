public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();
        Backtrack(0, candidates, target, current, 0, result);

        return result;
    }
    private void Backtrack(int i, int[] candidates, int target, List<int> current, int currentSum,
                           List<List<int>> result) {
        if (currentSum == target) {
            result.Add(new List<int>(current));
            return;
        }
        if (currentSum > target || i >= candidates.Length) {
            return;
        }
        current.Add(candidates[i]);
        Backtrack(i + 1, candidates, target, current, currentSum + candidates[i], result);
        current.RemoveAt(current.Count - 1);
        while (i + 1 < candidates.Length && candidates[i] == candidates[i + 1]) {
            i++;
        }
        Backtrack(i + 1, candidates, target, current, currentSum, result);
    }
}
