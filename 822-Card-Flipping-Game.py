def flipgame(fronts: 'List[int]', backs: 'List[int]') -> 'int':
    same = {x for i, x in enumerate(fronts) if x == backs[i]}
    ans = 0
    for x in fronts:
        if x not in same:
            ans = x if ans == 0 else min(ans, x)
    for x in backs:
        if x not in same:
            ans = x if ans == 0 else min(ans, x)

    return ans

#Runtime: 44 ms, faster than 100.00% of Python3 online submissions for Card Flipping Game.
print(flipgame([1,1], [2, 2]))