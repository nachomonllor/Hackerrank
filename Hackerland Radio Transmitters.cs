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
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] x_temp = Console.ReadLine().Split(' ');
            int[] x = Array.ConvertAll(x_temp, Int32.Parse);
            Array.Sort(x);
            int answer = 0;
            int medio = 0;
            for (int i = 0; i < x.Length; i++)
            {
                answer++;
                int mas_a_la_izq = x[i];
                while (i + 1 < x.Length && x[i + 1] - k <= mas_a_la_izq)
                {
                    i++;
                }
                medio = i;
                while (i + 1 < x.Length && x[i + 1] <= x[medio] + k)
                {
                    i++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
