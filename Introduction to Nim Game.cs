using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        //http://www.librosmaravillosos.com/matematicaepisodio3/capitulo04.html#11

        static List<int> descomponerEnPot2(int n)
        {
            List<int> res = new List<int>();
            int[] pot2 = { 64, 32, 16, 8, 4, 2, 1 };

            int sum = 0;
            for (int i = 0; i < pot2.Length; i++)
            {
                if (sum + pot2[i] <= n)
                {
                    //Console.Write(pot2[i] + " ");
                    res.Add(pot2[i]);
                    sum += pot2[i];
                }
            }
            return res;
        }

        static bool estaBalanceado(int[] s)
        {
            Dictionary<int, int> diccio = new Dictionary<int, int>();
            //64, 32, 16, 8, 4, 2, 1
            diccio[64] = 0;
            diccio[32] = 0;
            diccio[16] = 0;
            diccio[8] = 0;
            diccio[4] = 0;
            diccio[2] = 0;
            diccio[1] = 0;

            for (int i = 0; i < s.Length; i++)
            {
                List<int> potencias_de_2 = descomponerEnPot2(s[i]);
                foreach (int elem in potencias_de_2)
                {
                    diccio[elem]++;
                }
            }

            foreach (KeyValuePair<int, int> kvp in diccio)
            {
                if (kvp.Value % 2 != 0)
                {
                    //no balanceado
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {

            //Si la posición inicial está desbalanceada, el que empieza, gana. 
            //Si la posición inicial está balanceada, el que empieza, pierde.

            //int[] s = { 2, 1, 4 };
            //int[] s = { 1, 1 };

            int g = int.Parse(Console.ReadLine());

            while (g-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                if (!estaBalanceado(s))
                {
                    Console.WriteLine("First");
                }
                else
                {
                    Console.WriteLine("Second");
                }

            }

            Console.ReadLine();
        }


    }
}

