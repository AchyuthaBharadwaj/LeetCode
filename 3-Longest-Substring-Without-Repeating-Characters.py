def lengthOfLongestSubstring(s: 'str') -> 'int':
    if len(s) <= 1:
        return len(s)

    ans = 0
    l = []
    counter = 0
    for i in s:
        if i not in l:
            l.append(i)
            counter += 1
        else:
            ind = l.index(i)
            l = l[ind+1:] + [i]
            ans = ans if ans > counter else counter
            counter = len(l)
    
    ans = ans if ans > counter else counter
    return ans

#faster than 80.94% of Python3 online submissions for Longest Substring Without Repeating Characters.
s = 'abcabcbb'
print(lengthOfLongestSubstring(s))