using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Easy206;

namespace ConsoleApp1.Easy203
{
    class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;
            if (head.val == val)
            {
                return RemoveElements(head.next,val);
            }
            else
            {
                return new ListNode(head.val, RemoveElements(head.next, val));
            }
        }

        public ListNode initData(int[] arr)
        {
            ListNode head = null;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                head = new ListNode(arr[i], head);
            }

            return head;
        }
    }
}
