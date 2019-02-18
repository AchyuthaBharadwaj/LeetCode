def twoSum(nums: 'List[int]', target: 'int'):
    sub = [target - i for i in nums]

    for i in range(len(nums)):
        if nums[i] in sub:
            x = sub.index(nums[i])
            if x != i:
                return [i, x]


inp = [2, 7, 11, 15]
target = 9
print(twoSum(inp, target))