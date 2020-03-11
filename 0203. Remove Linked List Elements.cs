/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode a = new ListNode();
        a.next = head;
        
        ListNode b = a;
        ListNode c = a.next;
        
        while (c != null){
            if (c.val == val){
                b.next = c.next;
            }else{
                b = c;
            }
                
            c = c.next;
                
        }
            
            
        return a.next;
    }
}