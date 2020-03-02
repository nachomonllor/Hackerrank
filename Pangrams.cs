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
            string frase = Console.ReadLine(); // "The quick brown fox jumps over the lazy dog";

            bool[] marcas = new bool[26];



            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    marcas[(int)(char.ToLower(frase[i]) - 97)] = true;
                }
            }

            string answer = "pangram";
            for (int i = 0; i < marcas.Length; i++)
            {
                if (!marcas[i])
                {
                    answer = "not pangram";
                    break;
                }
            }

            Console.WriteLine(answer);


            Console.ReadLine();

        }

    }
}
