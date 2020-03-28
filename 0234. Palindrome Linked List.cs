/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        
        ListNode a = new ListNode(0);
        ListNode b = new ListNode(0);
        a = b;
        a = b = head;
        Stack<int> stack = new Stack<int>();
        
        while( a!=null && a.next!=null){
            stack.Push(b.val);
            b = b.next;
            a = a.next.next;
        }
            
            
        if(a!=null){
            b = b.next;
        }
            
            
        while(b!=null){
            var top = stack.Pop();
            
            if (top != b.val){
                return false;
            }  
            b = b.next;
        }
            
        
        return true;
    }
}