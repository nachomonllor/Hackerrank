using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void swap(bool[] arr, int p1, int p2)
        {
            bool temp = arr[p1-1];
            arr[p1-1] = arr[p2-1];
            arr[p2-1] = temp;
        }

        static void Main(string[] args)
        {

            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);

            bool[] arr = new bool[10];
            arr[m - 1] = true;

            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_a = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(tokens_a[0]);
                int b = Convert.ToInt32(tokens_a[1]);
                // your code goes here
                swap(arr, a, b);
            }

            Console.WriteLine(Array.IndexOf(arr, true)+1);
            Console.ReadLine();

        }
    }

    }
}
