# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def removeElements(self, head: ListNode, val: int) -> ListNode:
        
        #a 固定在第0位 return回傳整個ListNode a.next
        #b b跑得比c慢一項 找到等於val的值 必須把後面一項 拉到前一項 b.next = c.next
        #c 每項去尋找是否有等於val的值
        
        a = ListNode()
        a.next = head
        
        b,c = a,a.next
        
        while c :
            if c.val == val:
                b.next = c.next
            else:
                b = c
            c = c.next
            
        return a.next