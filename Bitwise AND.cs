﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int max_bit = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    int bitwise = i & j;
                    if (bitwise > max_bit && bitwise < k)
                    {
                        max_bit = bitwise;
                    }
                }
            }
            Console.WriteLine(max_bit);
        }
    }
}
