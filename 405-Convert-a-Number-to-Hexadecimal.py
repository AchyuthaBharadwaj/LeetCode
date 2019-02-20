def s32(value):
    return -(value & 0x80000000) | (value & 0x7fffffff)

def toHex(num: 'int') -> 'str':
    h_set = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f']
    if num == 0:
        return "0"
    if num < 0:
        num += 1<<32
    n = num
    out = ''
    while n > 0:
        out = h_set[n%16] + out
        n = int(n/16)

    return out

#Runtime: 32 ms, faster than 100.00% of Python3 online submissions for Convert a Number to Hexadecimal.
print(toHex(-1))