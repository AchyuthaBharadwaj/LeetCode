def largestSumOfAverages(A: 'List[int]', K: 'int') -> 'float':
    P = [0]
    for x in A: P.append(P[-1] + x)
    def average(i, j):
        return (P[j] - P[i])/float(j-i)
    
    N = len(A)
    dp = [average(i, N) for i in range(N)]
    for _ in range(K-1):
        for i in range(N):
            for j in range(i+1, N):
                dp[i] = max(dp[i], average(i, j) + dp[j])

    return dp[0]

#Runtime: 548 ms, faster than 42.24% of Python3 online submissions for Largest Sum of Averages.
print(largestSumOfAverages([4,1,7,5,6,2,3], 4))