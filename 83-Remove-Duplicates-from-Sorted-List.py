# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:
    def deleteDuplicates(self, head: ListNode) -> ListNode:
        temp = head
        if not temp:
            return temp
        while temp.next != None:
            if temp.val == temp.next.val:
                temp.next = temp.next.next
            else:
                temp = temp.next

        return head

#Runtime: 52 ms, faster than 61.73% of Python3 online submissions for Remove Duplicates from Sorted List.