public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int i = 0;
        for(i = 0; i < nums.Length; i++) {
            if (nums[i] >= target) {
                return i;
            }
        }
        return i;
    }
}