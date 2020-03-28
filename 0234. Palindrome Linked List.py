# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def isPalindrome(self, head: ListNode) -> bool:
        a = b = ListNode(0)
        a = b = head
        stack = []
        
        while a and a.next:
            stack.append(b.val)
            b = b.next
            a = a.next.next
            
        if a:
            b = b.next
            
        while b:
            top = stack.pop()
            
            if top != b.val:
                return False
            b = b.next
        
        return True