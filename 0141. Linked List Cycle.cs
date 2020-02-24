/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        
        ListNode a = head ;   //一次跳2位
        ListNode b = head ;  //一次跳1位
        
        while(a != null &&  a.next != null ){
            a = a.next.next ;
            b = b.next ;
            
            if (a == b){
                return true ;
            }
        }
            
        return false ;
    }
}