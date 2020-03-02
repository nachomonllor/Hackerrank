using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e));
        //int[] a = { 1, 3, 2 };
        Array.Sort(a);
        long miles = 0;
        long cupcakes = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            miles += a[i] * (long)Math.Pow(2, cupcakes++);
        }
        Console.WriteLine(miles);
    }
}
