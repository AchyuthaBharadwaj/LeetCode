def minMutation(start: 'str', end: 'str', bank: 'List[str]') -> 'int':
    s = start
    e = end
    queue = [(s, 0)]
    all_mutations = ["A", "C", "G", "T"]
    if s == e:
        return 0
    if len(bank) == 0 or e not in bank:
        return -1
    while len(queue) > 0:
        cur, level = queue.pop(0)
        for i in range(len(cur)):
            for mut in all_mutations:
                temp = cur[:i] + mut + cur[i + 1:]
                if temp == end:
                    return level + 1
                if temp != cur and temp in bank:
                    queue.append((temp, level+1))

    return -1

#Runtime: 36 ms, faster than 32.56% of Python3 online submissions for Minimum Genetic Mutation.
print(minMutation("AGCAAAAA", "GACAAAAA", ["AGTAAAAA","GGTAAAAA","GATAAAAA","GACAAAAA"]))