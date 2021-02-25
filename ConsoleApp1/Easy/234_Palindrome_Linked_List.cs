using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy234
{
    class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            List<int> lst = new List<int>();
            while (head != null)
            {
                lst.Add(head.val);
                head = head.next;
            }
            int i = 0, j = lst.Count - 1;
            while (j-i>0)
            {
                if (lst[i] == lst[j])
                {
                    i++;j--;
                }
                else
                {
                    return false;
                }
            }
            return true;
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
