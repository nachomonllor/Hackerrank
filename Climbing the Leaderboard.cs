using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string bin = Convert.ToString(n, 2);
        //Console.WriteLine(bin);
        int max_unos = 0;
        //int i = 0;
        //while (i < bin.Length)
        //{
        //    int cont = 0;
        //    while (i < bin.Length && bin[i] == '1')
        //    {
        //        cont++;
        //        i++;
        //    }
        //    max_unos = Math.Max(cont, max_unos);
        //    i++;
        //}
        
        //sin convertir previamente a binario
        while (n > 0)
        {
            int cont = 0;
            while (n % 2 == 1)
            {
                cont++;
                n /= 2;
            }
            max_unos = Math.Max(cont, max_unos);
            n /= 2;
        }


        Console.WriteLine(max_unos);

        Console.ReadLine();
    }



}
