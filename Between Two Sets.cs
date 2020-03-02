using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int ans = 0;
            for (int x = a.Max(); x <= b.Min(); x++)
            {
                int i;
                for (i = 0; i < n; i++)
                {
                    if (x % a[i] != 0)
                    {
                        break;
                    }
                }
                int j;
                for (j = 0; j < m; j++)
                {
                    if (b[j] % x != 0)
                    {
                        break;
                    }
                }
                if (i == n && j == m)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);

        }
    }
}
