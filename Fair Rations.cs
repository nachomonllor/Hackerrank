using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] B_temp = Console.ReadLine().Split(' ');
            int[] B = Array.ConvertAll(B_temp, e => int.Parse(e));
            int bread = 0;
            for (int i = 0; i < N; i++)
                if (B[i] % 2 == 1)
                {
                    bread += 2;
                    B[i]++;
                    if (i < N - 1)
                        B[i + 1]++;
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            Console.WriteLine(bread);
        }
    }
}
