def isPerfectSquare(num):
        if num==1:
            return True
        sum = 0
        i = 1
        while sum < num:
            sum += i
            if sum == num:
                return True
            i += 2
        return False

print(isPerfectSquare(100))