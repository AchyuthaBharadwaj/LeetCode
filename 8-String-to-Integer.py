def myAtoi(str: 'str') -> 'int':
    if len(str) == 0:
        return 0

    str = str.lstrip(' ')
    num = 0
    isNeg = False
    isFirstAlpha = True
    isNumSet = False
    for i in str:
        try:
            x = int(i)
            num = num * 10 + x
            isNumSet = True
        except ValueError:
            if i == '+' and isFirstAlpha == True and isNumSet == False:
                isFirstAlpha = False
                continue        
            elif i == '-' and isFirstAlpha == True and isNumSet == False:
                isNeg = True
                isFirstAlpha = False
                continue
            else:
                break

    if isNeg == True:
        num = num * -1

    if num >= 2**31: 
        return 2**31-1
    elif  num <= -2**31:
        return -2**31
    return num


#Runtime: 56 ms, faster than 99.06% of Python3 online submissions for String to Integer (atoi).
str = "2147483647"
print(myAtoi(str))
