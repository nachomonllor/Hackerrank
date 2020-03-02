using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
        int max = a[0];
        int min = a[0];
        int mayor_max = 0, menor_min = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                mayor_max++;
            }
            if (a[i] < min)
            {
                min = a[i];
                menor_min++;
            }
        }
        Console.WriteLine(mayor_max + " " + menor_min);
    }


}
