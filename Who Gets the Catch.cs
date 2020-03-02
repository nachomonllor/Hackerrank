using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int whoGetsTheCatch(int n, int x, int[] X, int[] V)
        {
            // Complete this function
            List<int> lista = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int distancia = Math.Abs(X[i] - x);
                int segundos = distancia / V[i];
                //if (lista.Contains(segundos))
                //{
                // return -1;
                //}
                lista.Add(segundos);
            }
            int minSeg = lista.Min();
            if (lista.IndexOf(minSeg) != lista.LastIndexOf(minSeg))
            {
                return -1;
            }
            return lista.IndexOf(minSeg);
        }

        static void Main(String[] args)
        {
            // Return the index of the catcher who gets the catch, or -1 if no one gets the catch.
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int x = Convert.ToInt32(tokens_n[1]);
            string[] X_temp = Console.ReadLine().Split(' ');
            int[] X = Array.ConvertAll(X_temp, Int32.Parse);
            string[] V_temp = Console.ReadLine().Split(' ');
            int[] V = Array.ConvertAll(V_temp, Int32.Parse);
            int result = whoGetsTheCatch(n, x, X, V);
            Console.WriteLine(result);
        }
    }
}
