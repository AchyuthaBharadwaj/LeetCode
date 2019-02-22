import collections

def getHint(secret: 'str', guess: 'str') -> 'str':
    bulls, cows = 0, 0
    s_dict, g_dict = collections.defaultdict(lambda: 0),collections.defaultdict(lambda: 0)
    for i in range(len(secret)):
        if secret[i] == guess[i]:
            bulls += 1
        else:
            s_dict[secret[i]] += 1
            g_dict[guess[i]] += 1
    for i in g_dict.keys():
        cows += min(s_dict[i], g_dict[i])
    return '{0}A{1}B'.format(bulls, cows)

#Runtime: 40 ms, faster than 100.00% of Python3 online submissions for Bulls and Cows.
print(getHint("1123", "0111"))