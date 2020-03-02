using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            int izq = 0, der = s.Length - 1;
            while (izq < der)
            {
                if (s[izq] != s[der])
                {
                    break;
                }
                izq++;
                der--;
            }
            string s_copia = s;
            s_copia = s_copia.Remove(izq, 1);
            char[] rev_s_copia = s_copia.ToCharArray();
            Array.Reverse(rev_s_copia);
            if (s_copia == new string(rev_s_copia))
            {
                Console.WriteLine(izq);
            }
            else
            {
                Console.WriteLine(der);
            }
        }
        Console.ReadLine();
    }
}
