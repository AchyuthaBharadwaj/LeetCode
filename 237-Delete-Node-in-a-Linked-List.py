# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

def deleteNode(node):
    while node.next.next != None:
        node.val = node.next.val
        node = node.next
    node.val = node.next.val
    node.next = None


#Runtime: 40 ms, faster than 99.95% of Python3 online submissions for Delete Node in a Linked List.
a = ListNode(3)
a.next = ListNode(4)
a.next.next = ListNode(5)
a.next.next.next = ListNode(6)

deleteNode(a)