using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1290
{
    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            var builder = new StringBuilder();
            List<byte> lst = new List<byte>();
            while (head != null)
            {
                builder.Append(head.val == 1 ? "1" : "0");
                head = head.next;
            }
            return Convert.ToInt32(builder.ToString(), 2);
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
