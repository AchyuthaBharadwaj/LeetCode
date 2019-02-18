def reverse(x: 'int') -> 'int':
    rev = str(x)[::-1]
    if rev[-1] == '-':
        rev = '-' + rev[:-1]
    
    res = int(rev)
    if res <= 2**31 -1 and res >= -2**31:
        return res
    return 0

#Runtime: 48 ms, faster than 100.00% of Python3 online submissions for Reverse Integer.
x = -12345
print(reverse(x))