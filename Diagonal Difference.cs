using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int d1 = 0;
            for (int i = 0; i < n; i++)
            {
                d1 += a[i][i];
            }

            int d2 = 0;
            for (int i = 0, j = a.Length - 1; j >= 0; i++, j--)
            {
                d2 += a[i][j];
            }

            Console.WriteLine(Math.Abs(d1 - d2));

            Console.ReadLine();
        }

    }
}
