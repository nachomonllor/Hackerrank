using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            //3
            //int[] a = { 2, 3, 1 };
            Dictionary<int, int> indices = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                indices[a[i]] = i;
            }
            for (int i = 1; i <= a.Length; i++)
            {
                //int pos = Array.IndexOf(a, i) + 1;
                //int indice_pos = Array.IndexOf(a, pos);
                //Console.WriteLine(indice_pos + 1);
                int pos = indices[i] + 1;
                int indice_pos = indices[pos];
                Console.WriteLine(indice_pos + 1);
            }
        }
    }
}
