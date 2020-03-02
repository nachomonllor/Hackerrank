using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            //int t1 = 0, t2 = 1, n = 5;
            int t1 = int.Parse(input[0].ToString());
            int t2 = int.Parse(input[1].ToString());
            int n = int.Parse(input[2].ToString());
            List<BigInteger> fib = new List<BigInteger>();
            fib.Add(t1);
            fib.Add(t2);
            for (int i = 2; i <= n; i++)
            {
                fib.Add(fib[i - 2] + (fib[i - 1] * fib[i - 1]));
            }
            //for (int i = 0; i < fib.Count; i++)
            //{
            // Console.Write(fib[i] + " ");
            //}
            Console.WriteLine(fib[n - 1]);
        }
    }
}
