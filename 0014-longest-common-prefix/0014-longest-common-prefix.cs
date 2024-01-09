public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        
        string longestPrefix = "";
        
        int smallestStringLength = int.MaxValue;
        
        for (int i = 0; i < strs.Length; i++) {
            if (strs[i].Length < smallestStringLength) {
                smallestStringLength = strs[i].Length;
            }
        }
        
        int index = 0;
        
        while (index < smallestStringLength) {
            int temp = strs[0][index];
            for (int i = 0; i < strs.Length; i++) {
                if (strs[i][index] != temp) {
                    return longestPrefix;
                }
            }            
            
            longestPrefix += strs[0][index];
            
            index++;
        }
        
        return longestPrefix;
    }
}