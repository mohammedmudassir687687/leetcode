class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        i = 0
        j = 0
        if len(nums) == 0:
            return 0
        seen = nums[i]
        while i < len(nums):
            j = i + 1
            if j < len(nums):
                if nums[j] == seen:
                    del (nums[j])
                    continue
                else:
                    seen = nums[j]
                    i += 1
                    continue
            break

        return len(nums)