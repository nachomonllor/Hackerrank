using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            //int n = 6;
            //int k = 3;
            //int[] a = Array.ConvertAll("10 20 30 100 101 102".Split(' '), e => int.Parse(e));


            Array.Sort(a);

            int min_dif = int.MaxValue;
            int ini = 0, fin = 0;
            for (int i = 0; i + k - 1 < a.Length; i++)
            {
                if (a[i + k - 1] - a[i] < min_dif)
                {
                    ini = i;
                    fin = i + k - 1;
                    min_dif = a[i + k - 1] - a[i];
                }
            }

            // Console.WriteLine(ini + " " + fin);


            Console.WriteLine(a[fin] - a[ini]);



            Console.ReadLine();
        }
    }
}

