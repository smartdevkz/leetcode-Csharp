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
            var solution = new Easy520.Solution();

            var res = solution.DetectCapitalUse("ffffffffffffffffffffF");
            //DisplayArray(a);

            //var res = solution.CommonChars(new[] { "bella", "label", "roller" });
            //solution.DisplayListNode(res);
            Console.WriteLine(res);
            //DisplayArray(res);

            Console.ReadKey();
        }

        static void DisplayArray(IList<string> arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
