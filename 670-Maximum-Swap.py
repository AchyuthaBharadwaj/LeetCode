def maximumSwap(num: 'int') -> 'int':
    s = list(str(num))
    if len(s) <= 1:
        return num
    ret = s[:]
    for i in range(len(s)):
        for j in range(i+1, len(s)):
            s[i], s[j] = s[j], s[i]
            if ret < s: 
                ret = s[:]
            s[i], s[j] = s[j], s[i]
    return int(''.join(ret))

#Runtime: 28 ms, faster than 100.00% of Python3 online submissions for Maximum Swap.
print(maximumSwap(1993))