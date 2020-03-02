using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        //string S = "SOSSPSSQSSOR";
        int N = 5; // or whatever
        string sos = string.Concat(Enumerable.Repeat("SOS", S.Length / 3).ToArray());
        //Console.WriteLine(sos);
        int ans = 0;
        for (int i = 0; i < S.Length; i++)
        {
            if (sos[i] != S[i])
            {
                ans++;
            }
        }
        Console.WriteLine(ans);
    }

}
