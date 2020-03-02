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

            /*la idea es ordenar primero el array para compararlo con el original*/


            //int n = 2;
            //int[] arr = { 4, 2 };

            //int n = 6;
            ////1, 2, 3, 4, 5, 6

            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            //int[] arr = { 1, 5, 4, 3, 2, 6 };
            int[] original = new int[arr.Length];
            Array.Copy(arr, original, arr.Length);

            Array.Sort(arr);

            /* recorro el array ordenado, si la cant de elementos diferentes
             * es 2, entonces quiere decir que se puede hacer un swap entre
             esos 2 elementos y obtener el array ordenado.
             * Al mismo tiempo busco el primer indice donde son distintos
             * y el ultimo indice donde son distintos, con esos indices
             * si la diferencia es mayor a 2 significa que no alcanza con 
             * hacer un swap, entonces revierto desde el primero hasta el 
             * ultimo indice, luego de eso me fijo si está ordenado
             */

            int i = 0;
            int distintos = 0;
            int iprim = -1, iult = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] != original[i])
                {
                    distintos++;
                }
                if (iprim == -1 && arr[i] != original[i])
                {
                    iprim = i;
                }
                if (iprim != -1 && arr[i] != original[i])
                {
                    iult = i;
                }
            }

            if (distintos == 2)
            {
                Console.WriteLine("yes");
                Console.WriteLine("swap {0} {1}", iprim + 1, iult + 1);
            }
            else if (distintos > 2)
            {
                int[] rev = new int[iult - iprim + 1];
                Array.Copy(original, iprim, rev, 0, iult - iprim + 1);
                Array.Reverse(rev);

                int indice_rev = 0;
                int[] nuevo = new int[arr.Length];
                Array.Copy(original, nuevo, arr.Length);
                for (i = iprim; i <= iult; i++)
                {
                    nuevo[i] = rev[indice_rev++];
                }
                //me fijo si esta ordenado
                i = 0;
                for (i = 0; i < arr.Length; i++)
                {
                    if (nuevo[i] != arr[i])
                    {
                        Console.WriteLine("no");
                        break;
                    }
                }
                if (i == arr.Length)
                {
                    Console.WriteLine("yes");
                    Console.WriteLine("reverse {0} {1}", iprim + 1, iult + 1);
                }

                // Console.WriteLine();
            }

            //Console.WriteLine(iprim + " " + iult);
            //Console.WriteLine(distintos);

            Console.ReadLine();

        }
    }
}

