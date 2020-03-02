﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            while (q-- > 0)
            {
                int a = int.Parse(Console.ReadLine());
                int[] antiprimos = { 1, 2, 4, 6, 12, 24, 36, 48, 60, 120, 180, 240, 360, 720, 840,
1260, 1680, 2520, 5040, 7560, 10080, 15120, 20160, 25200, 27720, 45360, 50400, 55440, 83160, 110880,
166320, 221760, 277200, 332640, 498960, 554400, 665280, 720720, 1081080, 1441440, 2162160, 2882880,
3603600, 4324320, 6486480, 7207200, 8648640, 10810800 };
                int ans = 0;
                for (int i = 0; i < antiprimos.Length; i++)
                {
                    if (antiprimos[i] >= a)
                    {
                        ans = antiprimos[i];
                        break;
                    }
                }
                sb.Append(ans);
                sb.Append("\n");
                // Console.WriteLine(ans);
            }
            Console.WriteLine(sb);
        }
    }
}
