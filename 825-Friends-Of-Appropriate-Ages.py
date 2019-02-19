def numFriendRequests(ages: 'List[int]') -> 'int':
    count = [0] * 121
    for age in ages:
        count[age] += 1
    
    ans = 0
    for ageA, countA in enumerate(count):
        for ageB, countB in enumerate(count):
            if ageA * 0.5 + 7 >= ageB: 
                 continue
            if ageA < ageB: 
                continue
            if ageA < 100 < ageB: 
                continue
            ans += countA * countB
            if ageA == ageB:
                ans -= countA
    return ans

# Runtime: 208 ms, faster than 36.00% of Python3 online submissions for Friends Of Appropriate Ages.

ages = [16, 17, 18]
print(numFriendRequests(ages))


""" My Solution##############################################
    def numFriendRequests(self, ages: 'List[int]') -> 'int':
        if len(ages) <= 1:
            return 0

        friend_requests = 0
        for i in range(len(ages)):
            for j in range(i):
                if i != j and ages[j] > 0.5 * ages[i] + 7 and ages[j] <= ages[i] and not (ages[j] > 100 and ages[i] < 100):
                    friend_requests += 1
                if i != j and ages[i] > 0.5 * ages[j] + 7 and ages[i] <= ages[j] and not (ages[i] > 100 and ages[j] < 100):
                    friend_requests += 1
        return friend_requests """