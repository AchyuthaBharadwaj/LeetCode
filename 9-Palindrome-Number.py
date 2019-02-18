#Coud you solve it without converting the integer to a string?

def isPalindrome(x: 'int') -> 'bool':
    rev = 0
    temp = x
    while temp > 0:
        rem = temp % 10
        rev = rev * 10 + rem
        temp = int(temp/10)

    return rev == x


#Runtime: 260 ms, faster than 75.44% of Python3 online submissions for Palindrome Number.
x = 123
print(isPalindrome(x))