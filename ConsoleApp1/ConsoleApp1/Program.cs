
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Easy2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test();
            run();
            Console.ReadKey();
        }

        static void run()
        {
            var solution = new Easy645.Solution();

            //var res = solution.HammingWeight(43261596);
            var res = solution.FindErrorNums(new int[] { 37, 62, 43, 27, 12, 66, 36, 18, 39, 54, 61, 65, 47, 32, 23, 2, 46, 8, 4, 24, 29, 38, 63, 39, 25, 11, 45, 28, 44, 52, 15, 30, 21, 7, 57, 49, 1, 59, 58, 14, 9, 40, 3, 42, 56, 31, 20, 41, 22, 50, 13, 33, 6, 10, 16, 64, 53, 51, 19, 17, 48, 26, 34, 60, 35, 5
});
            //DisplayArray(a);

            //var res = solution.CommonChars(new[] { "bella", "label", "roller" });
            //solution.DisplayListNode(res);
            //Console.WriteLine(res);
            DisplayArray(res);
            //DisplayLinkedList(res);
        }

        static void DisplayArray<T>(IList<T> arr)
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
                if (head != null) Console.Write("->");
            }
        }

        static void test()
        {
            int a = 5;
            Console.WriteLine(Convert.ToString(a, 2));
            //Console.WriteLine(Convert.ToString(a & 4, 2));
            Console.WriteLine(Convert.ToString(a << 1, 2));
            Console.WriteLine(Convert.ToString(a >> 1, 2));
            //var res = getSum(35, 118);
        }

        static int getSum(int a, int b)
        {
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine();
            return b == 0 ? a : getSum(a ^ b, (a & b) << 1); //be careful about the terminating condition;
        }
    }
}
