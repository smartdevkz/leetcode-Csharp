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
            List<byte> lst = new List<byte>();
            while (head != null)
            {
                lst.Add((byte)head.val);
            }
            int res = 0;
            for(int i = 0; i < lst.Count; i++) {
                res +=(int) (lst[lst.Count - 1 - i] * Math.Pow(2, i));
            }
            return res;
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
