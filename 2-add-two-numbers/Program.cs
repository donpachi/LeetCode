using System;

namespace _2_add_two_numbers
{
    class Program
    {
    
     //Definition for singly-linked list.
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    
        int carry = 0;
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode head = new ListNode(-1);   //create a faux head to start iteration from, return the next node from this point as the real head
            ListNode p = l1, q = l2, temp = head;
            while(l1 != null || l2 != null){
                temp.next = AddListNodes(l1, l2);
                temp = temp.next;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            if (carry == 1){
                temp.next = new ListNode(carry);
            }
            return head.next;
        }
        
        //this method takes care of the case where one of the nodes is null (end of one linked list)
        ListNode AddListNodes(ListNode l1, ListNode l2){
            int x = (l1 == null) ? 0 : l1.val;
            int y = (l2 == null) ? 0 : l2.val;
            int temp = x + y + carry;
            carry = temp > 9 ? 1 : 0;
            ListNode n = new ListNode(temp % 10);
            return n;
        }

        static void Main(string[] args)
        {
            //Driver to be finished
        }
    }
}
