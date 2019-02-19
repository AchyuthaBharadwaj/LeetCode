def integerReplacement(n: 'int') -> 'int':
    if n < 2:
        return 0
    if n == 2:
        return 1
    if n%2 == 0:
        return 1 + integerReplacement(int(n/2))
    else:
        return 1 + min(integerReplacement(n+1), integerReplacement(n-1))


#Runtime: 276 ms, faster than 27.43% of Python3 online submissions for Integer Replacement.
print(integerReplacement(1234))