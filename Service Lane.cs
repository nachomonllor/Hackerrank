﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int t = Convert.ToInt32(tokens_n[1]);
        string[] width_temp = Console.ReadLine().Split(' ');
        int[] width = Array.ConvertAll(width_temp, e => int.Parse(e));
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_i = Console.ReadLine().Split(' ');


            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            int[] fragmento = new int[j - i + 1];
            Array.Copy(width, i, fragmento, 0, j - i + 1);
            Console.WriteLine(fragmento.Min());
        }
    }
}