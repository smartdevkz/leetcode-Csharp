
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
            Random rnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(0, 2));
            }
            //run();
            Console.ReadKey();
        }

        static void run()
        {
            var solution = new Easy970.Solution();

            //var res = solution.HammingWeight(43261596);
            var res = solution.PowerfulIntegers(2, 3, 10);

            //DisplayArray(a);

            //var res = solution.CommonChars(new[] { "bella", "label", "roller" });
            //solution.DisplayListNode(res);
            Console.WriteLine(res);
            //DisplayArray(res);
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
