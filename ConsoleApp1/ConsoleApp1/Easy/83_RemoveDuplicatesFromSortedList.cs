using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy83
{
    class Solution
    {
        public ListNode GetInitialData()
        {
            //return new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, null)))));
            //return null;
            return new ListNode(4, null);
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            head = new ListNode(head.val, GetNext(head.val, head.next));
            return head;
        }

        public ListNode GetNext(int val,ListNode node)
        {
            if (node == null) return null;
            if (val == node.val)
            {
                return GetNext(val, node.next);
            }
            else
            {
                return new ListNode(node.val, GetNext(node.val, node.next));
            }
        }

        public void DisplayListNode(ListNode head)
        {
            var node = head;
            while (node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


}
