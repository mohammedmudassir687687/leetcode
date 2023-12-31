public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0 || s.Length == 1) {
            return s.Length;
        }

        int left = 0, right = 1;
        int size = s.Length;

        HashSet<char> charSet = new HashSet<char>();

        charSet.Add(s[left]);
        int length = 1;
        int maxlength = 1;

        while (right < size ) {
            if (!charSet.Contains(s[right])) {
                length++;
                if (length > maxlength) maxlength = length;
                charSet.Add(s[right]);
                right++;
            } else {
                while (charSet.Contains(s[right])) {
                    charSet.Remove(s[left]);
                    length--;
                    left++;
                }
                charSet.Add(s[right]); 
                length++;
                right++;
            }
        }

        return maxlength;
    }
}