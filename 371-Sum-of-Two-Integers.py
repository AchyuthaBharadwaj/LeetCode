def getSum(a: 'int', b: 'int') -> 'int':
    
    """ while b > 0:
        #& operator gives the carry bit
        carry = a & b

        #Xor operator gives the sum (^)
        a = a ^ b

        #add carrry to y to achieve correct addition
        b = carry << 1

    return a """

    return sum([a, b])

#Runtime: 28 ms, faster than 100.00% of Python3 online submissions for Sum of Two Integers.
print(getSum(19, 2))