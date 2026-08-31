public class Solution {
    public int MissingNumber(int[] nums) {
        int res = 0;
        int i = 0;
        while (i < nums.Length) {
            res = res ^ nums[i] ^ i;
            i++;
        }
        res = res ^ i;

        return res;
    }
}
