def findComplement(num: 'int') -> 'int':
    p = 1
    while num >= p:
        p = p * 2
    return num ^ (p-1)

#Runtime: 32 ms, faster than 100.00% of Python3 online submissions for Number Complement.
print(findComplement(1))