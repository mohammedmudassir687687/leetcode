public class Solution {
    public int LengthOfLastWord(string s) {
        string ns = s.Trim();
        string[] ls = ns.Split(" ");
        return ls[ls.Length - 1].Length;
    }
}