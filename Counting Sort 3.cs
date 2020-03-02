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
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine().Split(' ')[0]);
            }
            int[] cont = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                cont[arr[i]]++;
            }
            int total = 0;
            for (int i = 0; i < cont.Length; i++)
            {
                total += cont[i];
                Console.Write(total + " ");
            }
        }
    }
}
