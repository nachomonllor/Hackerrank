using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            Array.Sort(a);
            int i = 0;
            int cont = 0;
            while (i < a.Length)
            {
                int actual = a[i];
                int j = i + 1;
                while (j < a.Length && a[j] <= actual + 4)
                {
                    j++;
                }
                i = j;
                cont++;
            }
            Console.WriteLine(cont);

        }
    }
}
