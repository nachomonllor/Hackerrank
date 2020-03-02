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
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, e => int.Parse(e));
            // your code goes here
            Array.Sort(a);
            int min_dif = int.MaxValue;
            for (int i = 0; i + 1 < a.Length; i++)
            {
                min_dif = Math.Min(min_dif, Math.Abs(a[i] - a[i + 1]));
            }
            Console.WriteLine(min_dif);
        }
    }
}
