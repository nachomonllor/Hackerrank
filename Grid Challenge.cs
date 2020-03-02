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
            int n = int.Parse(Console.ReadLine());
            //string[] input = { "ebacd",
            //"fghij",
            //"olmkn",
            //"trpqs",
            //"xywuv" };
            // string[] input = { "kc","iu"};
            //string[] input = { "uxf",
            // "vof",
            // "hmp" };
            string[] input = new string[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }
            string[] ordenado = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char[] linea = input[i].ToCharArray();
                Array.Sort(linea);
                //Console.WriteLine(new string(linea));
                ordenado[i] = new string(linea);
            }
            //foreach (string s in ordenado)
            //{
            // Console.WriteLine(s);
            //}
            string ans = "YES";
            for (int col = 0; col < ordenado[0].Length; col++)
            {
                for (int fila = 0; fila + 1 < ordenado.Length; fila++)
                {
                    if (ordenado[fila][col] > ordenado[fila + 1][col])
                    {
                        ans = "NO";
                        break;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
