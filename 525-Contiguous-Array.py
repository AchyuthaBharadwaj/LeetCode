def findMaxLength(nums: 'List[int]') -> 'int':
    max_len = 0
    counter = 0
    dict = {0: 0}
    for idx, val in enumerate(nums, 1):
        if val == 1:
            counter += 1
        else:
            counter -= 1
        
        if counter in dict:
            max_len = max(max_len, idx - dict[counter])
        else:
            dict[counter] = idx

    return max_len

#Runtime: 248 ms, faster than 85.26% of Python3 online submissions for Contiguous Array.
print(findMaxLength([0,1]))
    