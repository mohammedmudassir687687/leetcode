class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        size = len(nums)
        sum = size * (size + 1) / 2
        for i in nums:
            sum -= i

        return int(sum)