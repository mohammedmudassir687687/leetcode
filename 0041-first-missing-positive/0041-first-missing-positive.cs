public class Solution {
    public int FirstMissingPositive(int[] nums) {
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < 0) nums[i] = 0;
        }
        int maxNumber = nums.Max();
        int left = 0;
        int right = nums.Length - 1;
        
        while (left < right) {
            if (nums[left] == 0) {
                left++;
                continue;
            }
            
            if (nums[right] != 0) {
                right--;
                continue;
            }
            
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            
            left++;
            right--;
        }
        
        int offset = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                offset++;
            }
        }
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0 || Math.Abs(nums[i]) + offset - 1 > nums.Length - 1 || Math.Abs(nums[i]) + offset - 1 < 0 ) {
                continue;
            }
            
            nums[Math.Abs(nums[i]) + offset - 1] = -1 * Math.Abs(nums[Math.Abs(nums[i]) + offset - 1]);
        }
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) {
                return i - offset + 1;
            }
            // Console.WriteLine(nums[i]);
        }
        return maxNumber + 1;
    }
}







































