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
            var res = app.Generate(4);
            //Console.WriteLine(res);
            //DisplayList(res);



            Console.ReadKey();
        }

        static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
