using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        class Elem
        {
            public int num;
            public int indice;

            public Elem()
            {

            }

            public Elem(int num, int indice)
            {
                this.num = num;
                this.indice = indice;
            }

        }



        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            //int[] indices = new int[n];

            Elem[] x = new Elem[n];
            int i, j;

            for ( i = 0; i < n; i++)
            {
                //indices[i] = i;
                x[i] = new Elem(arr[i], i);
            }

            //bubble sort
            //Array.Sort(arr, indices);


            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (x[j].num > x[j + 1].num)
                    {
                        // swap arr[j] and arr[j+1] 
                        Elem temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;

                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }


            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr [i] + " ");
            //}
            //Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write(x[i].indice + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }


        

    }
}
