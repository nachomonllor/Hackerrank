using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution
{
    static BigInteger Proximo(string s, BigInteger anterior, int desde)
    {
        if (s[desde] == '0')
        {
            return -1;
        }
        string concat = "";
        for (int i = desde; i < s.Length; i++)
        {
            concat += s[i].ToString();
            if (BigInteger.Parse(concat) == anterior + 1)
            {
                return BigInteger.Parse(concat);
            }
            else if (BigInteger.Parse(concat) > anterior + 1)
            {
                return -1;
            }
        }
        return -1;
    }
    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {


            string s = Console.ReadLine();
            // your code goes here
            if (s.Length == 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                BigInteger primero = BigInteger.Parse(s[0].ToString());
                BigInteger x = primero;
                int len_primero = 1;
                int desde = 1;
                string ans = "YES";
                while (len_primero < s.Length)
                {
                    ans = "YES";
                    while (desde < s.Length)
                    {
                        // Console.WriteLine(primero);
                        BigInteger prox = Proximo(s, primero, desde);
                        if (prox == -1)
                        {
                            ans = "NO";
                            break;
                        }
                        primero = prox;
                        desde += primero.ToString().Length;
                        if (desde == s.Length)
                        {
                            ans = "YES";
                            break;
                        }
                    }
                    if (ans == "YES")
                    {
                        break;
                    }
                    len_primero++;
                    primero = BigInteger.Parse(s.Substring(0, len_primero));
                    x = primero;
                    desde = len_primero;
                }
                if (ans == "YES")
                {
                    Console.WriteLine(ans + " " + x);
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}