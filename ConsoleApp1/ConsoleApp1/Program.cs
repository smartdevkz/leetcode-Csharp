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
            var solution = new Easy83.Solution();
            
            var res = solution.DeleteDuplicates(solution.GetInitialData());
            solution.DisplayListNode(res);
            //Console.WriteLine(res);
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
