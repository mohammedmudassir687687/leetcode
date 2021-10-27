class Solution:
    def sortColors(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        n = len(nums)
        cntZero = cntOne = cntTwo = 0
        for i in range(n):
            if nums[i] == 0:
                cntZero += 1
            elif nums[i] == 1:
                cntOne += 1
            else:
                cntTwo += 1

        for i in range(n):
            if cntZero > 0:
                nums[i] = 0
                cntZero -= 1
            elif cntOne > 0:
                nums[i] = 1
                cntOne -= 1
            else:
                nums[i] = 2
                cntTwo -= 1