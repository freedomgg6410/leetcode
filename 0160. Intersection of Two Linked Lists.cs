/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        
        ListNode a = headA;
        ListNode b = headB;
        
        while (a != b) {
             if (a == null){
                a = headB;  //headA 跑完接headB跑
            }else{
                a = a.next;
            }
        
            if (b == null){
                b = headA; 
            }else{
                b = b.next;
            }
            
        }
             
        return a; //return a或b其中一個 因為交叉點一樣
                   
    }
}