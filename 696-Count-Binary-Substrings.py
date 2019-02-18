def countBinarySubstrings(s: 'str') -> 'int':
    groups = [0]
    counter = 1
    out = 0
    for i in range(len(s)-1):
        if s[i] == s[i+1]:
            counter += 1
        else:
            groups.append(counter)
            out += min(groups[-1], groups[-2])
            counter = 1
            
    groups.append(counter)
    out += min(groups[-1], groups[-2])

    return out

#faster than 74.06% of Python3 online submissions for Count Binary Substrings.
s = '00110011'
print(countBinarySubstrings(s))