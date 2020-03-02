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
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int b = int.Parse(Console.ReadLine());
            int b_actual = arr.Sum();
            b_actual -= arr[k];
            b_actual /= 2;
            int res = b - b_actual;
            if (res == 0)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(res);
            }
        }
    }
}
