import math 

def validSquare(p1: 'List[int]', p2: 'List[int]', p3: 'List[int]', p4: 'List[int]') -> 'bool':
    def dist(p1, p2):
        return math.sqrt((p1[0] - p2[0])*(p1[0] - p2[0]) + (p1[1] - p2[1])*(p1[1] - p2[1]))
    l = [p1, p2, p3, p4]
    l.sort()

    d1 = dist(l[0], l[1])
    d2 = dist(l[0], l[2])
    d3 = dist(l[2], l[3])
    d4 = dist(l[1], l[3])
    diagonal1 = dist(l[0], l[3])
    diagonal2 = dist(l[1], l[2])
    if d1 > 0 and d1==d2 and d2==d3 and d3==d4 and diagonal1==diagonal2:
        return True
    return False

#Runtime: 40 ms, faster than 99.26% of Python3 online submissions for Valid Square.
print(validSquare([0,0], [1,1], [1,0], [0,2]))