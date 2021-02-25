using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy119
{
    class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex < 0) return null;
            if (rowIndex == 0) return new int[] { 1 };
            if (rowIndex == 1) return new int[] { 1, 1 };

            var prev = new int[] { 1, 1 };
            for (int i = 2; i <= rowIndex; i++)
            {
                var children = new int[i + 1];
                children[0] = 1;
                for (int j = 1; j < prev.Count(); j++)
                {
                    children[j] = prev[j - 1] + prev[j];
                }
                children[children.Length - 1] = 1;
                prev = children;
            }
            return prev;
        }
    }
}
