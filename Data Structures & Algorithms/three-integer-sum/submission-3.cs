public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
         Array.Sort(nums);
 var list = new List<List<int>>();
 for(int i = 0; i < nums.Length - 2; i++)
 {
     if (i > 0 && nums[i] == nums[i - 1]) continue;
     int left = i + 1;
     int right = nums.Length - 1;
     while (left < right)
     {
         int sum = nums[left] + nums[right] + nums[i];
         if (sum > 0)
         {
             right--;
         }
         else if (sum < 0)
         {
             left++;
         }
         else
         {
             list.Add(new List<int>() { nums[left], nums[i], nums[right] });
             left++;
             right--;
             while (left < right && nums[left] == nums[left - 1]) left++;
             while (left < right && nums[right] == nums[right + 1]) right--;
         }
     }
 }
 
 return list;
    }
}
