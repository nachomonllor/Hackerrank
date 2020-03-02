using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static string timeCompare(string t1, string t2)
        {
            // Complete this function
            DateTime d1 = DateTime.Parse(t1);
            DateTime d2 = DateTime.Parse(t2);
            return d1.CompareTo(d2) == 1 ? "Second" : "First";
        }
        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens_t1 = Console.ReadLine().Split(' ');
                string t1 = tokens_t1[0];
                string t2 = tokens_t1[1];
                string result = timeCompare(t1, t2);
                Console.WriteLine(result);
            }
        }
    }
}
