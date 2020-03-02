using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be
        */
        int t = int.Parse(Console.ReadLine());
        //6703734870638684097
        //7597026128958891522
        //13174607262084689114
        //6959712971461184279
        //12572864054437627553
        while (t-- > 0)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            // BigInteger n = BigInteger.Parse("6703734870638684097");
            string[] spot2 = { "18446744073709551616", "9223372036854775808",
"4611686018427387904", "2305843009213693952", "1152921504606846976", "576460752303423488",
"288230376151711744", "144115188075855872", "72057594037927936", "36028797018963968",
"18014398509481984", "9007199254740992", "4503599627370496", "2251799813685248", "1125899906842624",
"562949953421312", "281474976710656", "140737488355328", "70368744177664", "35184372088832",
"17592186044416", "8796093022208", "4398046511104", "2199023255552", "1099511627776", "549755813888",
"274877906944", "137438953472", "68719476736", "34359738368", "17179869184", "8589934592",
"4294967296", "2147483648", "1073741824", "536870912", "268435456", "134217728", "67108864",
"33554432", "16777216", "8388608", "4194304", "2097152", "1048576", "524288", "262144", "131072",
"65536", "32768", "16384", "8192", "4096", "2048", "1024", "512", "256", "128", "64", "32", "16", "8",
"4", "2", "1" };
            BigInteger[] pot2 = Array.ConvertAll(spot2, e => BigInteger.Parse(e));
            string winner = "Richard";
            while (true)
            {
                if (n == 1)
                {
                    break;
                }
                winner = (winner == "Louise") ? "Richard" : "Louise";
                if (!pot2.Contains(n))
                {
                    BigInteger largest_power = pot2[0];
                    for (int i = 0; i < pot2.Length; i++)
                    {
                        if (pot2[i] < n)
                        {
                            largest_power = pot2[i];
                            break;
                        }
                    }
                    n -= largest_power;
                }
                else
                {
                    n /= 2;
                }
            }
            //Console.WriteLine(n);
            Console.WriteLine(winner);
        }
    }
}
