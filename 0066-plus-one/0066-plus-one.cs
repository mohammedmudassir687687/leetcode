public class Solution {
    public int[] PlusOne(int[] digits) {
     
        
        int carry = 0;
        
        for (int i = digits.Length - 1; i > - 1; i--) {
            if (i == digits.Length - 1) {
                if (digits[i] + 1 == 10) {
                    digits[i] = 0;
                    carry = 1;
                } else {
                    digits[i]++;
                }
                continue;
            }
            if (digits[i] + carry == 10) {
                digits[i] = 0;
                carry = 1;
            } else {
                digits[i] += carry;
                carry = 0;
            }
        }
        
        if (carry == 0) {
            return digits;
        } 
        
        int[] newdigits = new int[digits.Length + 1];

        newdigits[0] = 1;
        for (int i = 0; i < digits.Length; i++) {
            newdigits[i+1] = digits[i];
        }

        
        return newdigits;
        
    }
}