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

            int n = int.Parse(Console.ReadLine().Trim());

            string[] input = Console.ReadLine().Trim().Split(' ');

            bool todos_negativos = true;
            long sum = 0, cont = 0;
            long max_neg = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                long elem = long.Parse(input[i]);
                if (elem >= 0)
                {
                    sum += elem;
                    cont++;
                    todos_negativos = false;
                }
                max_neg = Math.Max(max_neg, elem);
            }
            if (todos_negativos)
            {
                Console.WriteLine(max_neg  + " " +1); 
            }
            else
            {
                Console.WriteLine(sum + " " + cont);

            }


            Console.ReadLine();
        }


        

    }
}
