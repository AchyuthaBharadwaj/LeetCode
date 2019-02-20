def findTheDifference(s: 'str', t: 'str') -> 'str':
    while len(s) > 0:
        cur = s[0]
        count_s = s.count(cur)
        count_t = t.count(cur)
        if count_s != count_t:
            return cur
        s = s.replace(cur, '')
        t = t.replace(cur, '')
    return t

#Runtime: 36 ms, faster than 99.63% of Python3 online submissions for Find the Difference.
print(findTheDifference("abcfd", "abfcdef"))