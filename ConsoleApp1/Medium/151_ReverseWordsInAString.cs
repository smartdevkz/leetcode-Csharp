using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium151
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var arr = s.Trim().Split(' ');
            var lst = new List<string>();
            for(int i=arr.Length-1;i>=0; i--)
            {
                if (!string.IsNullOrEmpty(arr[i]))
                {
                    lst.Add(arr[i].Trim());
                }    
            }
            return string.Join(" ", lst);
        }
    }
}
