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
            int n = int.Parse(Console.ReadLine());

            int people = 5;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                //int res = people - (int)Math.Floor((people / (double)2));
                int res = (int)Math.Floor((people / (double)2));
               // Console.WriteLine(res);
                sum += res;
                people = res * 3;
            }

            Console.WriteLine( sum);

            Console.ReadLine();
        }
    }
}

