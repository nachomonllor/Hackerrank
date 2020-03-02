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
            //int n = 5;
            //string[] burgers = { "8 1", "4 2", "5 6", "3 1", "4 3" };

            //int n =2;
            //string[] burgers = { "1 1", "1 1" };


            int n = int.Parse(Console.ReadLine());
            string[] burgers = new string[n];

            int i;

            for (i = 0; i < n; i++)
            {
                burgers[i] = Console.ReadLine();
            }

            Dictionary<int, int> diccio = new Dictionary<int, int>();

            i = 0;
            foreach (string elem in burgers)
            {
                diccio[i] = int.Parse(elem.Split(' ')[0]) + int.Parse(elem.Split(' ')[1]);
                i++;
            }


            //foreach (KeyValuePair<int, int> kvp in diccio)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //}

            var items = from pair in diccio
                        orderby pair.Value ascending
                        select pair;


            //Console.WriteLine();
            foreach (KeyValuePair<int, int> kvp in items)
            {
                //Console.WriteLine(kvp.Key + " " + kvp.Value);
                Console.Write((kvp.Key + 1) + " ");
            }



            Console.ReadLine();

        }
    }
}
