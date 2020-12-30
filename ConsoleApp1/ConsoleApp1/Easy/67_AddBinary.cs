using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy67
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var builder = new StringBuilder();
            string r = "0";
            while (a.Length > 0 || b.Length > 0)
            {
                var sum = Add(a.Length > 0 ? a[a.Length - 1].ToString() : "0", b.Length > 0 ? b[b.Length - 1].ToString() : "0");
                sum = Add(sum, r);
                r = sum.Length > 1 ? "1" : "0";
                builder.Insert(0, sum[sum.Length - 1]);
                if (a.Length > 0)
                    a = a.Remove(a.Length - 1);
                if (b.Length > 0)
                    b = b.Remove(b.Length - 1);
            }
            if (r == "1") builder.Insert(0, "1");
            return builder.ToString();
        }

        public string Add(string a, string b)
        {
            if (a == "10") return b == "1" ? "11" : "10";
            if (a == "0") return b;
            return b == "0" ? "1" : "10";
        }
    }
}
