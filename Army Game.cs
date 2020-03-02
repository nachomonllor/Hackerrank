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
            if (n % 2 == 0)
            {
                n -= 2;
            }
            else if (n % 2 != 0)
            {
                n--;
            }
            if (n == 0)
            {
                n = 1;
            }
            if (m % 2 == 0)
            {
                m -= 2;
            }
            else if (m % 2 != 0)
            {
                m--;
            }
            if (m == 0)
            {
                m = 1;
            }
            Console.WriteLine(n * m);
        }
    }
}
