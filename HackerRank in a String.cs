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
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                // your code goes here
                string hack = "hackerrank";
                int ind_hack = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == hack[ind_hack])
                    {
                        ind_hack++;
                    }
                    if (ind_hack == hack.Length)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                }
                if (ind_hack < hack.Length)
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
