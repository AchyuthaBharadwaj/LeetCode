def findDuplicates(nums: 'List[int]') -> 'List[int]':
    ans = []
    for i in nums:
        if nums[abs(i)-1] < 0:
            ans.append(abs(i))
        else:
            nums[abs(i)-1] *= -1
    return ans

#Runtime: 160 ms, faster than 85.55% of Python3 online submissions for Find All Duplicates in an Array.
print(findDuplicates([1,3,5,4,2,1,3,5,2,4]))
