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
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);//prisioneros
                int m = int.Parse(input[1]);//dulces
                int s = int.Parse(input[2]);//id
                //string[] input = "999999999 999999999 1".Split(' ');
                //long n = int.Parse(input[0]);//prisioneros
                //long m = int.Parse(input[1]);//dulces
                //long s = int.Parse(input[2]);//id
                long resto = m % n;
                resto += (s - 1);
                if (resto > n)
                {
                    resto -= n;
                }
                if (resto == 0)
                {
                    resto = n;

                }

                Console.WriteLine(resto);

            }


        }


    }


}
