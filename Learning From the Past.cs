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
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            while (n-- > 0)
            {
                //int x = 1, y = 2, z = 3;
                string[] input = Console.ReadLine().Trim().Split(' ');
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                int z = int.Parse(input[2]);
                int[] arr = { x, y, z };
                Array.Sort(arr);
                //Console.WriteLine(arr[1] + arr[2]);
                max = Math.Max(max, arr[1] + arr[2]);
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
