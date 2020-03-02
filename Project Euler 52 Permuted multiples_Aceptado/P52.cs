using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void mostrar(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static bool compararDigitos(int[] ha, int b)
        {

            int[] hb = new int[10];
            while (b > 0)
            {
                hb[b % 10]++;
                b /= 10;
            }

            for (int i = 0; i < 10; i++)
                if (ha[i] != hb[i])
                    return false;

            return true;
        }


        static void findPermutedMultiples(int x, int K)
        {
            List<int> multiplos = new List<int>();
            for (int i = 2; i <= K; i++)
            {
                multiplos.Add(x * i);
            }

            int[] hx = new int[10];
            int x2 = x;
            while (x2 > 0)
            {
                hx[x2 % 10]++;
                x2 /= 10;
            }

            for (int i = 0; i < multiplos.Count; i++)
            {
                if (!compararDigitos(hx, multiplos[i]))
                {
                    return  ;
                }
            }

            Console.Write(x + " ");
            foreach (int elem in multiplos)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
          //  return  ;
          

        }


        static void Main(string[] args)
        {
            //bool b = compararDigitos(1567, 7516);
            //Console.WriteLine(b);
            string input = Console.ReadLine();

            int N = int.Parse(input.Split(' ')[0].ToString());
            int K = int.Parse(input.Split(' ')[1].ToString());  
            for (int i = 1; i <= N; i++)
            {
                findPermutedMultiples(i, K);
                
            }
            Console.ReadLine();

        }
    }
}
