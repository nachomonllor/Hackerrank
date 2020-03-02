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
            int n = 3;
            int[][] a =
            {
                new int[]{3, 1, 3},
                new int[]{2, 3, 4},
                new int[]{5, 5, 4}
            };





            int filas = a.Length, cols = a[0].Length;

            for (int i = 0; i < a.Length; i++)
            {

                for (int j = 0; j < a[i].Length; j++)
                {

                    for (int k = i; k < filas; k++)
                    {
                        for (int l = j; l < cols; l++)
                        {
                            Console.Write(a[k][l] + " ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                }


            }

            Console.ReadLine();
        }
    }
}
