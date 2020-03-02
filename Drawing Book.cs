using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class Program
    {
         int solve(int n, int p)
        {
            // Complete this function
            return (Math.Min(p, n - p) / 2);
        }
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int result = solve(n, p);
            Console.WriteLine(result);
        }
    }
}
