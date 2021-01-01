using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public class Solution415
    {
        public string AddStrings(string num1, string num2)
        {
            var builder = new StringBuilder();
            var dict = GetDigits();
            int r = 0;
            int i = 1;
            while (i <= num1.Length || i <= num2.Length)
            {
                var a = i <= num1.Length ? dict[num1[num1.Length - i]] : 0;
                var b = i <= num2.Length ? dict[num2[num2.Length - i]] : 0;
                var sum = a + b + r;
                r = sum / 10;
                builder.Insert(0, sum % 10);
                i++;
            }
            if (r > 0) builder.Insert(0, r);
            return builder.ToString();
        }

        Dictionary<char, int> GetDigits()
        {
            var dict = new Dictionary<char, int>();
            dict.Add('0', 0);
            dict.Add('1', 1);
            dict.Add('2', 2);
            dict.Add('3', 3);
            dict.Add('4', 4);
            dict.Add('5', 5);
            dict.Add('6', 6);
            dict.Add('7', 7);
            dict.Add('8', 8);
            dict.Add('9', 9);
            return dict;
        }
    }
}
