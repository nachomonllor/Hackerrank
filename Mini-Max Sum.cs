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
            long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e));
            Array.Sort(a);
            Console.WriteLine((a[0] + a[1] + a[2] + a[3]) + " " + (a[1] + a[2] + a[3] + a[4]));
        }
    }
}
