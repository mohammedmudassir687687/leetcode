public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        
        IList<IList<int>> res = new List<IList<int>>();
        
        calcPerm(res, new List<int>(), new List<int>(nums));
        return res;
    }


    public void calcPerm(IList<IList<int>> res, IList<int> buildList, IList<int> remainingList) {
        if (remainingList.Count == 0) {
            res.Add(buildList);
            return;
        }
  
        for (int i = 0; i < remainingList.Count; i++) {
            var newBuildList = buildList.Select((a) => a).ToList();
            var newRemainingList = remainingList.Where((a) => a != remainingList[i]).ToList();
            newBuildList.Add(remainingList[i]);
            calcPerm(res, newBuildList, newRemainingList);
        }

    }
}