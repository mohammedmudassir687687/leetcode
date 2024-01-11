public class Solution {
    public IList<string> LetterCombinations(string digits) {
        
        if (digits.Length == 0) {
            return new List<string>();
        }
        
        List<string> combinations = new List<string>();
        var dict = new Dictionary<char, List<string>> {
            {'2', new List<string> {"a", "b", "c"}},
            {'3', new List<string> {"d", "e", "f"}},
            {'4', new List<string> {"g", "h", "i"}},
            {'5', new List<string> {"j", "k", "l"}},
            {'6', new List<string> {"m", "n", "o"}},
            {'7', new List<string> {"p", "q", "r", "s"}},
            {'8', new List<string> {"t", "u", "v"}},
            {'9', new List<string> {"w", "x", "y", "z"}},
        };
        
        List<string> listA = new List<string>{""};
        List<string> listB = new List<string>{""};
        List<string> listC = new List<string>{""};
        List<string> listD = new List<string>{""};
        
        
        for (int i = 0; i < digits.Length; i++) {
            if (i == 0)
                listA = dict[digits[i]];
            else if (i == 1)
                listB = dict[digits[i]];
            else if (i == 2)
                listC = dict[digits[i]];
            else if (i == 3)
                listD = dict[digits[i]];
        }
        
        foreach(var itemA in listA) {
            foreach (var itemB in listB) {
                foreach (var itemC in listC) {
                    foreach (var itemD in listD) {
                        combinations.Add(itemA + itemB + itemC + itemD);
                    }
                }
            }
        } 
        
        
        return combinations;
    }
}