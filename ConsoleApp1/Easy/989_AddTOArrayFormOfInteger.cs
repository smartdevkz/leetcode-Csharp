using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy989
{
    public class Solution
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            var lst = new List<int>();
            int r = 0;
            int i = 1;
            var Kstr = K.ToString();
            while (i <= A.Length || i <= Kstr.Length)
            {
                var a = i <= A.Length ? Convert.ToInt32(A[A.Length - i].ToString()) : 0;
                var b = i <= Kstr.Length ? Convert.ToInt32(Kstr[Kstr.Length - i].ToString()) : 0;
                var sum = a + b + r;
                r = sum / 10;
                lst.Insert(0, sum % 10);
                i++;
            }
            if (r > 0) lst.Insert(0, r);
            return lst;
        }
    }
}
