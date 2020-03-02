using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        long t = long.Parse(Console.ReadLine());
        long total = 0;
        long n = 3;
        while (total < t)
        {
            total += n;
            n *= 2;
        }
        n /= 2;
        Console.WriteLine(total - n + (n - t) + 1);
    }
}