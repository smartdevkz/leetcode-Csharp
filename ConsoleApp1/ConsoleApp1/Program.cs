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
            var app = new Easy();
            //var res = app.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            var res = app.CountAndSay(2);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        
    }
}
