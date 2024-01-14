public class Solution {
    public string ReverseWords(string s) {
        
        if (s.Length == 0) {
            return "";
        }
        
        List<string> list = new List<string>();
        string tempString = "";
        foreach(char c in s) {
            if (c != ' ') {
                tempString += c;
            } else {
                if (tempString != "")
                    list.Add(tempString);
                tempString = "";
            }
        }
        if (tempString != "") {
            list.Add(tempString);
        }
        
        list.Reverse();
        string res = string.Join(" ", list);
        return res;
    }
}