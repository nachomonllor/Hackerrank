using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int puntos_alice = 0, puntos_bob = 0;
            int[] alice = { a0, a1, a2 };
            int[] bob = { b0, b1, b2 };
            for (int i = 0; i < 3; i++)
            {
                puntos_alice += (alice[i] > bob[i]) ? 1 : 0;
                puntos_bob += (bob[i] > alice[i]) ? 1 : 0;
            }
            Console.WriteLine(puntos_alice + " " + puntos_bob);
        }
    }
}
