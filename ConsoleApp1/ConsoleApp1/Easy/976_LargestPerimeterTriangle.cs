using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy976
{
    public class Solution
    {
        public int LargestPerimeter(int[] A)
        {
            if (A.Length < 3) return 0;
            Array.Sort(A);
            for(int i = A.Length-1; i >=2; i--)
            {
                if (A[i - 2] + A[i - 1] > A[i]) return A[i - 1] + A[i - 2] + A[i];
            }
            return 0;
        }
    }
}
