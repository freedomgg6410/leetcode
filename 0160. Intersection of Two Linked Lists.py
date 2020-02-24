# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def getIntersectionNode(self, headA: ListNode, headB: ListNode) -> ListNode:
        
        a = headA
        b = headB
        
        while a != b :
            if not a :
                a = headB   #headA 跑完接headB跑
            else:
                a = a.next
                
        
            if not b :
                b = headA   #headB 跑完接headA跑
            else:
                b = b.next
                
        return a #return a或b其中一個 因為交叉點一樣
            