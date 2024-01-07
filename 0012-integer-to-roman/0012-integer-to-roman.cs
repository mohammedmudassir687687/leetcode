public class Solution {
    public string IntToRoman(int num) {
        
        string res = "";
        

            while (num - 1000 >= 0) {
                res += "M";
                num -= 1000;
            }
            
            while (num - 900 >= 0) {
                res += "CM";
                num -= 900;
            }
            
            while (num - 500 >= 0) {
                res += "D";
                num -= 500;
            }
            
            while (num - 400 >= 0) {
                res += "CD";
                num -= 400;
            }
            
            while (num - 100 >= 0) {
                res += "C";
                num -= 100;
            }
            
            while (num - 90 >= 0) {
                res += "XC";
                num -= 90;
            }
            
            while (num - 50 >= 0) {
                res += "L";
                num -= 50;
            }
            
            while (num - 40 >= 0) {
                res += "XL";
                num -= 40;
            }
            
            while (num - 10 >= 0) {
                res += "X";
                num -= 10;
            }
            
            while (num - 9 >= 0) {
                res += "IX";
                num -= 9;
            }
            while (num - 5 >= 0) {
                res += "V";
                num -= 5;
            }
            while (num - 4 >= 0) {
                res += "IV";
                num -= 4;
            }
            while (num > 0) {
                res += 'I';
                num -= 1;
            }
        
        return res;
        }
        
        
    
}