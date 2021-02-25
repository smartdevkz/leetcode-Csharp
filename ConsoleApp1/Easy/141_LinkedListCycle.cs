using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy141
{
    class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var lst = new List<ListNode>();
            while (head != null)
            {
                if (lst.Contains(head))
                {
                    return true;
                }
                else
                {
                    lst.Add(head);
                }
                head = head.next;
            }
            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
