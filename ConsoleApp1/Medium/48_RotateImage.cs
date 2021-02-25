using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium48
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            var origin = InitArr(n, matrix);
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matrix[j][n - 1 - i] = origin[i][j];
                }
            }
        }

        public int[][] InitArr(int n, int[][] matrix)
        {
            var arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    arr[i][j] = matrix[i][j];
                }
            }
            return arr;
        }
    }
}
