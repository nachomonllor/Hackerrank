using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int c = Convert.ToInt32(tokens_n[1]);
        int m = Convert.ToInt32(tokens_n[2]);
        string[] p_temp = Console.ReadLine().Split(' ');
        int[] p = Array.ConvertAll(p_temp, Int32.Parse);
        int max_pas = c * m;
        string ans = "Yes";
        for (int i = 0; i < p.Length; i++)
        {
            if (p[i] > max_pas)
            {
                ans = "No";
                break;
            }
        }
        Console.WriteLine(ans);
    }
}
