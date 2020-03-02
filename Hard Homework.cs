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
            double n = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double max = 0;
            for (double i = 1; i < n; i++)
            {
                for (double j = 1; j < n; j++)
                {
                    double resto = n - i - j;
                    double suma = Math.Sin(i) + Math.Sin(j) + Math.Sin(resto);
                    max = Math.Max(max, suma);
                }
            }
            Console.WriteLine(max.ToString("0.000000000"));

        }
    }
}
