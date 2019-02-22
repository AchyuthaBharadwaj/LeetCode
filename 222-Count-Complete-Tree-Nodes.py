class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

def countNodes(root: 'TreeNode') -> 'int':
    if not root:
        return 0
    queue = [root]
    counter = 0
    while len(queue) > 0:
        cur = queue.pop(0)
        counter += 1
        if cur.left:
            queue.append(cur.left)
        if cur.right:
            queue.append(cur.right)
    return counter

#Runtime: 136 ms, faster than 29.61% of Python3 online submissions for Count Complete Tree Nodes.
print(countNodes(TreeNode(3)))