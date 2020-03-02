using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be
        named Solution */
        int n = int.Parse(Console.ReadLine());
        int[] lados = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
        //int[] lados = { 1, 1, 1, 3, 3 };
        //int[] lados = { 6,5,4,3,2,1 };
        Array.Sort(lados);
        Array.Reverse(lados);
        string ans = "-1";
        for (int i = 0; i < lados.Length - 2; i++)
        {
            //Console.WriteLine(lados[i] + " " + lados[i + 1] + " " + lados[i + 2]);
            if (lados[i + 1] + lados[i + 2] > lados[i])
            {
                ans = "";
                ans += lados[i + 2] + " " + lados[i + 1] + " " + lados[i];
                break;
            }
        }
        Console.WriteLine(ans);
    }