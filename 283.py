class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        i = 0
        j = 1
        while i < len(nums):

            if nums[i] != 0:
                i += 1
            else:
                j = i + 1
                while j < len(nums):
                    if nums[j] == 0:
                        j += 1
                    else:
                        nums[i] = nums[j]
                        nums[j] = 0
                        break

                i += 1