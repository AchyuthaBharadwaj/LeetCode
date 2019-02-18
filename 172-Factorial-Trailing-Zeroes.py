def trailingZeroes(n: 'int') -> 'int':
    num_zeros = 0
    p = 5
    while p <= n:
        num_zeros += int(n/p)
        p = 5 * p
    return num_zeros

print(trailingZeroes(4617))