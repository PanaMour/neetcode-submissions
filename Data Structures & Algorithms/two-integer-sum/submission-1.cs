public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i<nums.Length;i++){
            if(!map.ContainsKey(nums[i])){
                map[target - nums[i]] = i;
            }
            else return new int[] { map[nums[i]], i};
        }
        return new int[0];
    }
}
