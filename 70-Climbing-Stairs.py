class Solution:
    def climbStairs(self, n: int) -> int:
        if n == 1:
            return 1
        dp = [0] * (n+1)
        dp[1], dp[2] = 1, 2
        for i in range(3, n+1):
            dp[i] = dp[i-1] + dp[i-2]
        return dp[n]

#Runtime: 40 ms, faster than 38.71% of Python3 online submissions for Climbing Stairs.
sol = Solution()
print(sol.climbStairs(3))