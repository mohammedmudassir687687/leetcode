class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i in range(len(nums)):
            reqEl = target - nums[i]

            if reqEl in nums:
                if nums.index(reqEl) != i:
                    return [i, nums.index(reqEl)]