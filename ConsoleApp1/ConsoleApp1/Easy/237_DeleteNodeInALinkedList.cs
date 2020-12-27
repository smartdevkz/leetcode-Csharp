using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy237
{
    class Solution
    {
        public void DeleteNode(ListNode node)
        {
            if (node == null) return;
            if (node.next != null)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
            else
            {
                node = null;
            }
        }
    }

    public class ListNode
    {
         public int val;
         public ListNode next;
         public ListNode(int x) { val = x; }
     }
}
