public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        
        Dictionary<char, char> dict = new Dictionary<char, char>{
            {')', '('},
            {'}', '{'},  
            {']', '['}  
        };
        
        foreach(var item in s) {
            if (item == ')' || item == '}' || item == ']') {
                if (st.Count > 0 && dict[item] == st.Peek()) {
                    st.Pop();
                } else {
                    return false;
                }
            } else {
                st.Push(item);
            }
        }
        
        if (st.Count == 0) {
            return true;
        } else {
            return false;
        }
    }
}