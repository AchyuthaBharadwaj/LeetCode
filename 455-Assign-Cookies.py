def findContentChildren(g: 'List[int]', s: 'List[int]') -> 'int':
    g.sort()
    s.sort()
    i = 0
    j = 0
    count = 0
    while i < len(g) and j < len(s):
        if g[i] <= s[j]:
            count += 1
            i += 1
        j += 1
    return count

#Runtime: 68 ms, faster than 99.85% of Python3 online submissions for Assign Cookies.
print(findContentChildren([1,2], [1,2,3]))