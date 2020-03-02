using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static bool esPrimo(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            //if (n % 2 == 0) return false;

            int sqr = (int)Math.Sqrt(n);
            for (int i = 3; i <= sqr; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static string rotar(string S)
        {
            return S[S.Length - 1] + S.Substring(0, S.Length - 1);
        }

        static bool esPrimoCircular(string S)
        {
            string R = S;
            //me fijo si contiene un par o un 5
            for (int i = 0; i < S.Length; i++)
            {
                int dig = int.Parse(S[i].ToString());
                if (dig % 2 == 0 || dig == 5) return false;
            }
            
            for (int i = 0; i < S.Length; i++)
            {
                //Console.WriteLine(R);
                if (!esPrimo(int.Parse(R)))
                {
                    return false;
                }

                R = rotar(R);
               
            }
            return true;

        }




        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int sum = 7;
            for (int i = 3; i <= N; i += 2)
            {
                if (esPrimoCircular(i.ToString()))
                {
                   // Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine(sum);
           // Console.ReadLine();

        }


    }
}
