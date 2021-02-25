using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy2
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> lst = new List<int>();
            int r = 0;
            while (l1 != null || l2 != null)
            {
                var a = l1 != null ? l1.val : 0;
                var b = l2 != null ? l2.val : 0;
                var sum = a + b + r;
                lst.Add(sum % 10);
                r = sum / 10;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            if (r > 0) lst.Add(r);
            return Init(lst.ToArray());
        }

        public ListNode Init(int[] arr)
        {
            ListNode node = null;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                node = new ListNode(arr[i], node);
            }
            return node;
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
