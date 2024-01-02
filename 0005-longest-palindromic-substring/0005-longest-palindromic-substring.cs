public class Solution {
    
    public string LongestPalindrome(string s) {
        
        
        if (s == "" || s == null) {
            return "";
        }
        
        if (s.Length == 1) 
        {
            return s;
        }
        
        
        int start = 0, end = 0, maxLength = 0;
        
        for (int i = 0; i < s.Length; i++) {
            int len1 = FindPalindromicString(s, i, i);
            int len2 = FindPalindromicString(s, i, i+1);

            int len = Math.Max(len1, len2);
            
            if (len > end-start){
                start = i - (len-1)/2;
                end = i + len/2;
                maxLength = len;
            }
        }
        return s.Substring(start, maxLength);
        
    }
    
    public int FindPalindromicString(string s, int left, int right) {
        if (left < 0 || right >= s.Length) {
            return 0;
        }
        
        while (left >= 0 && right < s.Length && s[right] == s[left]) {
            left--;
            right++;
        }
        
        return right - left - 1;
    }
}