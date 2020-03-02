using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int lowestTriangle(int b, int a)
        {
            //Console.WriteLine( (2 * a) / (double) b);
            return (int)Math.Ceiling((2 * a) / (double)b);
        }
        static void Main(String[] args)
        {
            string[] tokens_base = Console.ReadLine().Split(' ');
            int base_ = Convert.ToInt32(tokens_base[0]);
            int area = Convert.ToInt32(tokens_base[1]);
            int height = lowestTriangle(base_, area);
            Console.WriteLine(height);
        }
    }
}
