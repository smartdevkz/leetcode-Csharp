﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Easy206;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Easy203.Solution();

            var res = solution.RemoveElements(solution.initData(new int[] { 1, 2, 6, 3, 4, 5, 6,7 }), 6);
            //DisplayArray(a);

            //var res = solution.CommonChars(new[] { "bella", "label", "roller" });
            //solution.DisplayListNode(res);
            //Console.WriteLine(res);
            //DisplayArray(res);
            DisplayLinkedList(res);
            Console.ReadKey();
        }

        static void DisplayArray(IList<string> arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void DisplayLinkedList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val);
                head = head.next;
                if(head!=null)Console.Write("->");
            }
        }
    }
}
