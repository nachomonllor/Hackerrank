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
            int n = int.Parse(Console.ReadLine());

            List<List<char>> lista = new List<List<char>>();

            for (int i = 0; i < n; i++)
            {
                string roca = Console.ReadLine();
                //listaRocas.Add(roca);
                List<char> actual = new List<char>();
                for (int j = 0; j < roca.Length; j++)
                {
                    if (!actual.Contains(roca[j]))
                    {
                        actual.Add(roca[j]);
                    }
                }
                lista.Add(actual);
            }

            int cont = 0;
            for (int i = 0; i < lista[0].Count; i++)
            {
                bool esta = true;
                for (int j = 0; j < lista.Count; j++)
                {
                    if (!lista[j].Contains(lista[0][i]))
                    {
                        esta = false;
                    }
                }
                if (esta)
                {
                    cont++;
                }

                //Console.WriteLine();
            }


            Console.WriteLine(cont);

            Console.ReadLine();

        }

    }
}
