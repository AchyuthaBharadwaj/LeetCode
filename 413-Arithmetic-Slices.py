class Solution:
    def __init__(self):
        self.sum = 0
    
    def slices(self, A, i):
        if i < 2:
            return 0
        ap = 0
        if A[i] - A[i-1] == A[i-1] - A[i-2]:
            ap = 1 + self.slices(A, i-1)
            self.sum += ap
        else:
            self.slices(A, i-1)
        return ap

    def numberOfArithmeticSlices(self, A: 'List[int]') -> 'int':
        self.slices(A, len(A) - 1)
        return self.sum

#Runtime: 36 ms, faster than 78.61% of Python3 online submissions for Arithmetic Slices.
sol = Solution()
print(sol.numberOfArithmeticSlices([1, 2, 3, 4]))