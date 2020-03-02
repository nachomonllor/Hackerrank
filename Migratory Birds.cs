using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] types_temp = Console.ReadLine().Split(' ');
        int[] types = Array.ConvertAll(types_temp, Int32.Parse);
        // your code goes here
        int[] t = new int[5];
        for (int i = 0; i < types.Length; i++)
        {
            t[types[i] - 1]++;
        }
        int max_frec = t.Max();
        int ans = 0;
        for (int i = 0; i < 5; i++)
        {
            if (t[i] == max_frec)
            {
                ans = i + 1;
                break;
            }
        }
        Console.WriteLine(ans);
    }
}