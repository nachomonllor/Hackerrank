using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static string isSatisfiable(int c1, int c2, int h1, int h2)
        {
            // Complete this function
            return Math.Max(c1, c2) <= Math.Min(h1, h2) ? "YES" : "NO";
        }
        static void Main(String[] args)
        {
            // Return "YES" if all four conditions can be satisfied, and "NO" otherwise
            string[] tokens_c1 = Console.ReadLine().Split(' ');
            int c1 = Convert.ToInt32(tokens_c1[0]);
            int c2 = Convert.ToInt32(tokens_c1[1]);
            int h1 = Convert.ToInt32(tokens_c1[2]);
            int h2 = Convert.ToInt32(tokens_c1[3]);
            string result = isSatisfiable(c1, c2, h1, h2);
            Console.WriteLine(result);
        }
    }
}
