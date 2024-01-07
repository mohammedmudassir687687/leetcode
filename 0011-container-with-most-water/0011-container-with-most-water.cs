public class Solution {
    public int MaxArea(int[] height) {
        
        
        int left = 0;
        int right = height.Length - 1;
        
        int max = 0;
        bool leftMax = false;
        bool rightMax = false;
        bool equal = false;
        while (left < right) {
            
            if (height[left] > height[right]) {
                leftMax = true;
                rightMax = false;
                equal = false;
            } else if (height[left] < height[right]) {
                rightMax = true;
                leftMax = false;
                equal = false;
            } else {
                equal = true;
                rightMax = false;
                leftMax = false;
            }
            
            if (leftMax) {
                if (height[right] * (right-left) > max) {
                    max = height[right] * (right - left);
                }
                right--;
            }
            else if (rightMax) {
                if (height[left] * (right-left) > max) {
                    max = height[left] * (right - left);
                }
                left++;
            } else if (equal) {
                if (height[left] * (right-left) > max) {
                    max = height[left] * (right - left);
                }
                
                if (height[left + 1] >= height[right - 1]) {
                    left++;
                } else {
                    right--;
                }
            }
            
            
        }
        return max;
        
        
        
    }
}