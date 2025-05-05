/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode value=head;

        while(value!=null &&value.next!=null){

            if(value.val== value.next.val){
                value.next=value.next.next;
            }
            else {
                value= value.next;
            }
        }
        return head;
        
    }
}