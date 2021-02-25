using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy412
{
    class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            var arr = new string[n]; 
            for(int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    arr[i - 1] = "FizzBuzz";
                }
                else if(i % 3 == 0)
                {
                    arr[i - 1] = "Fizz";
                }
                else if(i % 5 == 0)
                {
                    arr[i - 1] = "Buzz";
                }
                else
                {
                    arr[i - 1] = i.ToString();
                }
            }
            return arr;
        }
    }
}
