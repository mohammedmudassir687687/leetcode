public class Solution {
    public int MaxSubArray(int[] nums) {
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < nums[i] + nums[i - 1]) {
                nums[i] = nums[i] + nums[i - 1];
            }
        }
        
        int max = int.MinValue;
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > max) {
                max = nums[i];
            }
        }
        
        return max;
    }
}