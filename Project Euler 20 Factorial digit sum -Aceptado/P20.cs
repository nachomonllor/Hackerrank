using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConsoleApplication2
{
    class Program
    {


        static int factorial(int N)
        {
            BigInteger prod = 1;
            for (int i = 2; i <= N; i++)
            {
                prod = BigInteger.Multiply(prod, i);
            }
            
            string pString = prod.ToString();
            int sum = 0;
            for (int i = 0; i < pString.Length; i++)
            {
                sum += int.Parse(pString[i].ToString());
            }
 
            return sum;
        }

        static void Main(string[] args)
        {

            int T = int.Parse(Console.ReadLine());


            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine(factorial(N));
            }

            Console.ReadLine();

        }


    }
}
