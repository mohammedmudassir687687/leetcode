public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates); 
        IList<IList<int>> res = new List<IList<int>>();
        HashSet<string> checkPresent = new HashSet<string>();
        res = AddCombinations(candidates, target, res, new List<int>{}, checkPresent);
        return res;    
    }
    
    public IList<IList<int>> AddCombinations(int[] candidates, int target, IList<IList<int>> res, List<int> temp, HashSet<string> checkPresent) {
        
        foreach(int num in candidates) {
            List<int> forTemp = temp.OrderBy(a=>a).ToList();
            if (target - num > 0) {
                forTemp.Add(num);
                string s = "";
                foreach(int item in forTemp) {
                    s += "-" + item;
                }
                if (!checkPresent.Contains(s)) {
                    checkPresent.Add(s);
                    AddCombinations(candidates, target - num, res, forTemp, checkPresent);
                } 
                
            } else if (target - num == 0) {
                forTemp.Add(num);
                forTemp = forTemp.OrderBy(a=>a).ToList();
                string s = "";
                foreach(int item in forTemp) {
                    s += "-" + item;
                }
                if (!checkPresent.Contains(s)) {
                    checkPresent.Add(s);
                    res.Add(forTemp);
                    forTemp = new List<int>{};
                }
            } else {
                forTemp = new List<int>{};
            }
        } 
        return res;
        
    }
    
    

}








