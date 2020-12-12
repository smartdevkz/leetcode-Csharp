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
            var solution = new Easy1539.Solution();

            var res = solution.FindKthPositive(new int[] { 2, 3, 4, 7, 11 }, 5);
            //solution.DisplayListNode(res);
            Console.WriteLine(res);
            //DisplayArray(res);

            Console.ReadKey();
        }

        static void DisplayArray(IList<int> arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
