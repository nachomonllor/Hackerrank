using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static bool isMegaPrime(long n)
        {
            string ns = n.ToString();
            string noPrimos = "14689";//2357

            foreach (char ch in ns)
            {
                if (ns.Contains(ch))
                {
                    return false;
                }
            }

            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            long sqr = (long)Math.Sqrt(n);
            for (int i = 3; i <= sqr; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            long first = long.Parse(Console.ReadLine());
            long last = long.Parse(Console.ReadLine());

            long ans = 0;
            for (long i = first; i <= last; i++)
            {
                if (isMegaPrime(i))
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}
