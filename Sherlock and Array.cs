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
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                if (n == 1)
                {
                    Console.WriteLine("YES");
                    continue;
                }

                int izq = 0, der = a.Sum();
                izq += a[0];
                der -= a[0];

                string ans = "NO";

                for (int i = 1; i + 1 < a.Length; i++)
                {
                    der -= a[i];
                    if (izq == der)
                    {
                        ans = "YES";
                        break;
                    }

                    izq += a[i];
                }

                Console.WriteLine(ans);


            }

        }


    }
}

