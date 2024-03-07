public class Solution {
    public string AddBinary(string a, string b) {
        string res = "";
        
        int length1 = a.Length - 1;
        int length2 = b.Length - 1;
        int carry = 0;
        
        while (length1 > -1 && length2 > -1) {
            int num1 = 0, num2 = 0;
            if (a[length1] == '1') num1 = 1;
            if (b[length2] == '1') num2 = 1;
            
            int total = num1 + num2 + carry;
            if (total == 3) {
                res = "1" + res;
                carry = 1;
            } else if (total == 2) {
                res = "0" + res;
                carry = 1;
            } else if (total == 1) {
                res = "1" + res;
                carry = 0;
            } else {
                res = "0" + res;
                carry = 0;
            }
            length1--;
            length2--;
        }
        
        while (length1 > -1) {
            int num1 = 0;
            if (a[length1] == '1') num1 = 1;
            
            if (carry + num1 == 2) {
                res = "0" + res;
                carry = 1;
            } else if (carry + num1 == 1) {
                res = "1" + res;
                carry = 0;
            } else {
                res = "0" + res;
                carry = 0;
            }
            length1--;
        }
        
        while (length2 > -1) {
            int num2 = 0;
            if (b[length2] == '1') num2 = 1;
            if (carry + num2 == 2) {
                res = "0" + res;
                carry = 1;
            } else if (carry + num2 == 1) {
                res = "1" + res;
                carry = 0;
            } else {
                res = "0" + res;
                carry = 0;
            }
            length2--;
        }

        
        if (carry == 1) res = "1" + res;
        
        return res;
    }
}