using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, e => int.Parse(e));
        //int[] a = { 4, 6, 5, 3, 3, 1 };
        //Console.WriteLine(pairs(arr));
        //int[] a = { 1, 2, 2, 3, 1, 2 };
        //int[] a = { 66, 66, 66, 66, 66, 66, 66, 66 };
        int max_len = 0;
        for (int i = 0; i < a.Length; i++)
        {
            int cont_actual = a.Count(e => e == a[i]);
            max_len = Math.Max(max_len, cont_actual);
            max_len = Math.Max(max_len, cont_actual + a.Count(e => e == (a[i] - 1)));
            max_len = Math.Max(max_len, cont_actual + a.Count(e => e == (a[i] + 1)));
        }
        Console.WriteLine(max_len);
        Console.ReadLine();
    }
}
