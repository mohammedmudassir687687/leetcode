public class Solution {
    public string ReverseVowels(string s) {
        
        char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        
        char[] input = s.ToCharArray(0, s.Length);
        
        int left = 0;
        int right = s.Length - 1;
        
        while (left < right) {
            while (left < right && !vowels.Contains(input[left])) {
                left++;
            }
            
            while (right > left && !vowels.Contains(input[right])) {
                right--;
            }
            
            if (left < right) {
                char temp = input[left];
                input[left] = input[right];
                input[right] = temp;
            }
            left++;
            right--;
        }
        
        string res = string.Join("", input);
        return res;
    }
}