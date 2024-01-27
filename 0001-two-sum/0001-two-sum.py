class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        hs = {}
        for i in range(len(nums)):
            hs[nums[i]] = i
        
        
        for j in range(len(nums)):
            numberToFind = target - nums[j]
            if numberToFind in hs and j != hs[numberToFind]:
                return [hs[numberToFind],j]
        