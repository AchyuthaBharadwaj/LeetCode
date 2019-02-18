def convert(s: 'str', numRows: 'int') -> 'str':
    
    if numRows == 0:
        return ''
    if numRows == 1:
        return s

    l = ['' for i in range(numRows)]
    incr = 1
    counter = 0
    for i in range(len(s)):    
        l[counter] += s[i]
        if (incr > 0 and (counter+1)%numRows == 0) or (incr < 0 and counter == 0):
            incr = -1 * incr
        counter += incr
        print(l)
    return "".join(l)

s = 'PAYPALISHIRING'
numrows = 4
print(convert(s, numrows))