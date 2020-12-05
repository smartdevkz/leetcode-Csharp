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
            var res = app.LengthOfLastWord("Hello World");
            Console.WriteLine(res);
            Console.ReadKey();
        }

        
    }
}
