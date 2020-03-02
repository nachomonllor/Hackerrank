using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] RotarDerecha(int[] arr, int k)
        {
            k = k % arr.Length;

            int[] rotado = new int[arr.Length];

            int i = 0;
            for (i = k; i < rotado.Length; i++)
            {
                rotado[i] = arr[i - k];
            }

            for (int j = i - k; j < arr.Length; j++)
            {
                rotado[j - (i - k)] = arr[j];
            }

            return rotado;

        }

        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] rotado = RotarDerecha(arr, 6);

            foreach (int elem in rotado)
            {
                Console.Write(elem + " ");
            }

            Console.ReadLine();
        }



        //static void Main(string[] args)
        //{
        //    //int[] arr = { 1, 2, 3, 4, 5 };

        //    //int[] rotado = RotarDerecha(arr, 3);
        //    //foreach (int elem in rotado)
        //    //{
        //    //    Console.Write(elem + " ");
        //    //}
        //    string[] tokens_n = Console.ReadLine().Split(' ');
        //    int n = Convert.ToInt32(tokens_n[0]);
        //    int k = Convert.ToInt32(tokens_n[1]);
        //    int q = Convert.ToInt32(tokens_n[2]);
        //    string[] a_temp = Console.ReadLine().Split(' ');
        //    int[] a = Array.ConvertAll(a_temp,e=> int.Parse(e));

        //    int[] rotado = RotarDerecha(a, k);

        //    for (int a0 = 0; a0 < q; a0++)
        //    {
        //        int m = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine(rotado[m]);
        //    }
        //    Console.ReadLine();
        //}


    }
}

