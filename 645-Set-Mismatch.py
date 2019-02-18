def findErrorNums(nums: 'List[int]') -> 'List[int]':
    dict = {i+1: 0 for i in range(len(nums))}

    for i in nums:
        dict[i] += 1

    missing = 0
    duplicate = 0

    for key, val in dict.items():
        if val == 0:
            missing = key
        elif val > 1:
            duplicate = key
    
    return [duplicate, missing]


# Solution faster than 70%

inp = [1, 2, 2, 4]
print(findErrorNums(inp))