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
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int E = 100;
            for (int i = 0; i < n; i += k)
            {
                if (c[i] == 0)
                {
                    E--;
                }
                else
                {
                    E -= 3;
                }
            }
            Console.WriteLine(E);


        }

    }

}
