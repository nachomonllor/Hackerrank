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
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int[] cont = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                cont[a[i]]++;
            }
            for (int i = 0; i < cont.Length; i++)
            {
                //Console.Write(cont[i] + " ");
                for (int j = 0; j < cont[i]; j++)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
