# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def deleteDuplicates(self, head: ListNode) -> ListNode:
        x = head
        while x:
            if x.next and x.next.val == x.val:
                x.next = x.next.next
            else:
                x = x.next
                
        return head