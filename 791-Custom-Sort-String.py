import collections

class Solution:
    def customSortString(self, S: 'str', T: 'str') -> 'str':
        dicS = {ch:i for i,ch in enumerate(S)}
        dicT = collections.Counter(T)
        res = [""]*len(S)
        for key, val in dicS.items():
            if key in dicT:
                res[val] = key*dicT[key]
        for key, val in dicT.items():
            if key not in dicS:
                res.append(key*val)
        return "".join(res)

#Runtime: 40 ms, faster than 38.93% of Python3 online submissions for Custom Sort String.
sol = Solution()
print(sol.customSortString("cba", "abcd"))