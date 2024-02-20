public class Solution {
    public int Jump(int[] nums) {
        
        if (nums.Length == 1) return 0;
        
        int[] dp = new int[nums.Length];
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                dp[i] = int.MaxValue;
            }
        }
        
        dp[nums.Length - 1] = 0;
        
        for (int i = nums.Length - 1; i > -1; i--) {
            if (i == nums.Length - 1 || nums[i] == 0) continue;
            int min = int.MaxValue;
            for (int j = i + 1; j < nums.Length && j <= i + nums[i]; j++) {
                if (dp[j] < min) {
                    min = dp[j];
                }
            }
            
            if (min == int.MaxValue) {
                dp[i] = int.MaxValue;
            }
            else if (nums[i] != 0) {
                dp[i] = 1 + min;
            }
                
           
        }
        return dp[0];
    }
}