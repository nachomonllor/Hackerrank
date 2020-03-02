using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < n; a0++)
        {
            string s = Console.ReadLine();
            int costo = 0;
            for (char ch = 'a'; ch <= 'z'; ch++)
                if (s.Contains(ch))
                    costo++;
            Console.WriteLine(costo);
        }
    }
}