using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution
        */
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);//prisioneros
            int m = int.Parse(input[1]);//dulces
            int s = int.Parse(input[2]);//id
            //string[] input = "999999999 999999999 1".Split(' ');
            //long n = int.Parse(input[0]);//prisioneros
            //long m = int.Parse(input[1]);//dulces
            //long s = int.Parse(input[2]);//id
            long resto = m % n;
            resto += (s - 1);
            if (resto > n)
            {
                resto -= n;
            }
            if (resto == 0)
            {
                resto = n;
            }
            Console.WriteLine(resto);
        }
    }
}