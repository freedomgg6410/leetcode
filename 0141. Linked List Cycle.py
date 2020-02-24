# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def hasCycle(self, head: ListNode) -> bool:
        
        a = head    #一次跳2位
        b = head    #一次跳1位
        
        while a and a.next:
            a = a.next.next
            b = b.next
            
            if a == b:
                return True
        
        return False