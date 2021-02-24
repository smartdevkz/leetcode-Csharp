using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hard51
{
    public class Solution
    {
        public void Run(int n)
        {
            //var res = SolveNQueens(4);
            //Display(res);

            var lst = new List<List<int>>();
            var res = Init(n);
            Generate(res, 0);

            while (res[0] != -1)
            {
                lst.Add(res.ToList());
                int start = res[0];
                res = Init(n);
                res[0] = start;
                Generate(res, 0);
            }

            Display(lst.ToArray());
        }

        public IList<IList<string>> SolveNQueens(int n)
        {
            var lst = new List<List<int>>();
            var res = Init(n);
            Generate(res, 0);

            while (res[0] != -1)
            {
                lst.Add(res.ToList());
                int start = res[0];
                res = Init(n);
                res[0] = start;
                Generate(res, 0);
            }

            return Convert(lst);
        }

        IList<IList<string>> Convert(List<List<int>> lst)
        {
            var converted = new List<List<string>>();
            foreach (var res in lst)
            {
                List<string> resStr = new List<string>();
                var builder = new StringBuilder();
                int n = res.Count();
                int i = 0;
                int j = 0;
                while (i < n * n)
                {
                    if (j < res.Count() && i == res[j])
                    {
                        builder.Append("Q");
                        j++;
                    }
                    else
                    {
                        builder.Append(".");
                    }
                    i++;
                    if (i % n == 0)
                    {
                        resStr.Add(builder.ToString());
                        builder = new StringBuilder();
                    }
                }
                converted.Add(resStr);
            };
            return converted.ToArray();
        }

        int[] Init(int n)
        {
            var lst = new List<int>();
            for (int i = 0; i < n; i++) lst.Add(-1);
            return lst.ToArray();
        }

        void Generate(int[] res, int pos)
        {
            if (pos * pos >= res.Count()) return;
            if (pos == -1) return;
            if (res[res.Length - 1] >= 0) return;
            int last = res[pos];
            if (pos == 0)
            {
                res[pos] = -1;
            }
            else if (pos > 0)
            {
                if (last == -1) last = res[pos - 1];
            }
            var val = GetNext(res, ++last);
            if (val == -1)
            {
                res[pos] = -1;
                --pos;
            }
            else
            {
                res[pos] = val;
                pos++;
            }
            Generate(res, pos);
        }

        int GetNext(int[] res, int val)
        {
            int n = res.Length;
            if (val >= n * n) return -1;
            return !isAttacked(res, val) ? val : GetNext(res, ++val);
        }

        bool isAttacked(int[] res, int val)
        {
            int n = res.Length;
            foreach (var item in res)
            {
                if (item < 0) break;
                int current = item;
                while ((current + 1) % n != 0)
                {
                    current++;
                    if (current == val) return true;
                }

                current = item;
                while (current < n * n)
                {
                    current += (n - 1);
                    if ((current + 1) % n == 0) break;
                    if (current == val) return true;
                }

                current = item;
                while (current < n * n)
                {
                    current += n;
                    if (current == val) return true;
                }

                current = item;
                while (current < n * n)
                {
                    current += (n + 1);
                    if (current == val) return true;
                }
            }
            return false;
        }

        void Display(int[] res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        void Display(IList<IList<string>> res)
        {
            foreach (var arr in res)
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item + " ");
                }
                Console.WriteLine("");
            }
        }

        void Display(IList<IList<int>> res)
        {
            foreach (var arr in res)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
