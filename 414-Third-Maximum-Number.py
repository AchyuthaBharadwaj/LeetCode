def thirdMax(nums: 'List[int]') -> 'int':
    new_list = list(set(nums))
    if len(new_list)<3:
        return max(nums)
    for _ in range(2):
            del new_list[new_list.index(max(new_list))]
    return max(new_list)

#Runtime: 44 ms, faster than 48.49% of Python3 online submissions for Third Maximum Number.
x = [3, 2, 2, 1]
print(thirdMax(x))