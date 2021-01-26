using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium59
{
    public class Solution
    {
        public int[][] GenerateMatrix(int n)
        {
            var arr = InitArr(n);

            int i = 0, j = -1, k = 0;
            bool goRight = true, goDown = false, goLeft = false, goUp = false;
            while (goRight || goDown || goLeft || goUp)
            {
                if (goRight)
                {
                    if (j + 1 >= n || arr[i][j + 1] > 0)
                    {
                        goDown = true;
                        goRight = false;
                    }
                    else
                    {
                        arr[i][++j] = ++k;
                    }
                }
                if (goDown)
                {
                    if (i + 1 >= n || arr[i + 1][j] > 0)
                    {
                        goDown = false;
                        goLeft = true;
                    }
                    else
                    {
                        arr[++i][j] = ++k;
                    }
                }
                if (goLeft)
                {
                    if (j - 1 < 0 || arr[i][j-1] > 0)
                    {
                        goLeft = false;
                        goUp = true;
                    }
                    else
                    {
                        arr[i][--j] = ++k;
                    }
                }
                if (goUp)
                {
                    if (i-1 < 0 || arr[i-1][j] > 0)
                    {
                        goUp = false;
                        goRight = true;
                    }
                    else
                    {
                        arr[--i][j] = ++k;
                    }
                }
                if (k == n * n) break;
            }
            return arr;
        }

        public int[][] InitArr(int n)
        {
            var arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
            }
            return arr;
        }

        public void Display(int[][] arr)
        {
            foreach (var item in arr)
            {
                foreach (var val in item)
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
    }
}