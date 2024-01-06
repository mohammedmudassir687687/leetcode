public class Solution {
    public int Reverse(int x) {
        bool isNegative = false;
        
        if (x < 0) {
            
            if (x <= -1 * Math.Pow(2, 31)) return 0;            
            isNegative = true;
            x *= -1;
        } else if (x > 0) {
            if (x > Math.Pow(2, 31) + 1) return 0;  
        } else return 0;
     
        int temp = x; 
        int newNum = 0;
        while(temp != 0) {
            int rem = temp % 10;
            
            if (isNegative) {
                if (-1 * (newNum + 0.1 * rem) < -1 * Math.Pow(2, 31) / 10.0) {
                    return 0;
                }
            } else {
                if (newNum + 0.1 * rem > (Math.Pow(2, 31) - 1) / 10.0) {
                    return 0;
                } 
            }
            
            newNum = newNum * 10 + rem;
            temp /= 10;
        }
        
        return isNegative ? -1 * newNum : newNum;
        

    }
}