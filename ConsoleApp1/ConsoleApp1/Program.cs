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
            var solution = new Easy121.Solution();

            var res = solution.MaxProfit(new int[] { 7,1,5,3,6,4});
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
