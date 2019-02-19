from datetime import datetime

def findMinDifference(timePoints: 'List[str]') -> 'int':
    def t_convert(time):
        return int(time[:2]) * 60 + int(time[3:])
    
    minutes = [0] * len(timePoints)
    for i in range(len(timePoints)):
        minutes[i] = t_convert(timePoints[i])  
    
    minutes.sort()

    m = min((y - x)%(24*60) for x, y in zip(minutes, minutes[1:] + minutes[:1]))
    
    return m

#Runtime: 56 ms, faster than 89.67% of Python3 online submissions for Minimum Time Difference.
x = ["23:59","00:00","19:30"]
print(findMinDifference(x))