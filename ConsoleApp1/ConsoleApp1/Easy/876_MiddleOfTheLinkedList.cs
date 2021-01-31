using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{

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

    public class Solution876
    {
        public ListNode MiddleNode(ListNode head)
        {
            var midNode = head;
            var node = head;
            int mid = 1;
            int k = 0;
            bool goNext = false;
            while (node != null)
            {
                k++;
                if (k >= 2 * mid)
                {
                    goNext = true;
                    mid++;
                }
                node = node.next;
                if (goNext)
                {
                    midNode = midNode.next;
                    goNext = false;
                }
            }
            return midNode;
        }
    }
}
