# Definition for a binary tree node.
class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def isSameTree(self, p: TreeNode, q: TreeNode) -> bool:
        if (not p and q) or (not q and p):
            return False
        if not p and not q:
            return True
        p_queue = [p]
        q_queue = [q]
        while len(p_queue) > 0:
            cur_p = p_queue.pop(0)
            cur_q = q_queue.pop(0)
            if cur_p.val != cur_q.val:
                return False
            if cur_p.left and cur_q.left:
                p_queue.append(cur_p.left)
                q_queue.append(cur_q.left)
            elif (cur_p.left and not cur_q.left) or (not cur_p.left and cur_q.left):
                return False
            if cur_p.right and cur_q.right:
                p_queue.append(cur_p.right)
                q_queue.append(cur_q.right)
            elif (cur_p.right and not cur_q.right) or (not cur_p.right and cur_q.right):
                return False
        return True 


#Runtime: 40 ms, faster than 39.18% of Python3 online submissions for Same Tree.