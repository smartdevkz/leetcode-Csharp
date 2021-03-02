
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test();
            run();
        }

        static void run()
        {
            var solution = new ConsoleApp1.Easy455.Solution();

            var res = solution.FindContentChildren(new int[]{1,2,3}, new int[]{4});

            Console.WriteLine(res);

            //DisplayArray(a);

            //var res = solution.CommonChars(new[] { "bella", "label", "roller" });
            //solution.DisplayListNode(res);
            //Console.WriteLine(res);
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

    }
}
