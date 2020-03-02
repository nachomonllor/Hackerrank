using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = long.Parse(Console.ReadLine());
            //string s = "a";
            //long n = 1000000000000;
            //string s = "aab";//588525
            //long n = 882787;
            //string s = "aba";
            //long n = 10;
            //string s = "afcfffaged";//192529151691
            //long n = 962645758455;
            //long count = 0;
            //string s =
            "bcbccacaacbbacabcabccacbccbababbbbabcccbbcbcaccababccbcbcaabbbaabbcaabbbbbbabcbcbbcaccbccaabacbbacbc";
            //long n = 649606239668;//162401559918
            int a_s = s.Count(e => e == 'a');
            long cantidad_s = n / s.Length;
            long sobra = n % s.Length;// s.Length ‐ ((s.Length * Math.Ceiling(cantidad_s)) ‐ n);
            // Console.WriteLine(sobra);
            Console.WriteLine((long)((long)(cantidad_s * a_s)
            + (s.Substring(0, (int)sobra).Count(e => e == 'a'))));
        }
    }
}
