
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
            var solution = new ConsoleApp1.Easy242.Solution();

            var res = solution.IsAnagram("anagram","nagaram");

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
