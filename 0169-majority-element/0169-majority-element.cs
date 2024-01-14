public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> freq = new Dictionary<int,int>();
        
        foreach(var item in nums) {
            if (!freq.ContainsKey(item)) {
                freq[item] = 1;
            } else {
                freq[item] += 1;
            }
        }
        
        
        int maxItem = 0;
        int max = int.MinValue;
        
        foreach(var item in freq) {
            if (item.Value > max) {
                max = item.Value;
                maxItem = item.Key;
            }
        }
        
        return maxItem;
    }
}