using System;
using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                //if (m != 1)
                //{
                // if (n % 2 == 0)
                // {
                // Console.WriteLine(2);
                // }
                // else
                // {
                // Console.WriteLine(1);
                // }
                //}
                //else
                //{
                // Console.WriteLine(2);
                //}
                Console.WriteLine(m != 1 ? n % 2 == 0 ? 2 : 1 : 2);
            }
        }
    }
}
