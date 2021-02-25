using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy19
{
    class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var node = head;
            int k = 0;
            while (node != null)
            {
                node = node.next;
                k++;
            }
            return GetNext(head, 0, k - n);
        }

        public ListNode GetNext(ListNode node, int index, int k)
        {
            if (node == null) return new ListNode();
            if (index != k)
            {
                return new ListNode(node.val, GetNext(node.next, ++index, k));
            }
            else
            {
                return node.next != null ? new ListNode(node.next.val, node.next.next) : new ListNode();
            }
        }

        public ListNode GetInitialData()
        {
            //return new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            //return null;
            return new ListNode(1, null);
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
