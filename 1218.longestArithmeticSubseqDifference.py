class Solution:
    def longestSubsequence(self, arr: List[int], difference: int) -> int:
        n = len(arr)

        dp = {}
        ans = 0

        for num in arr:
            target = num - difference

            if target not in dp:
                dp[num] = 1
            else:
                dp[num] = 1 + dp[target]

            ans = max(ans, dp[num])

        return ans