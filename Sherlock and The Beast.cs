using System;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int cant_5 = n, cant_3 = 0;
                int i = cant_5;
                for (i = cant_5; i >= 0; i--)
                {
                    if (cant_5 % 3 == 0 && cant_3 % 5 == 0)
                    {
                        break;
                    }
                    cant_5--;
                    cant_3++;
                }
                if (i <= 0 && cant_5 <= 0 && cant_3 > n)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    // Console.WriteLine(cant_5 + " " + cant_3);
                    Console.WriteLine(new string('5', cant_5) +
                    new string('3', cant_3));
                }
            }
        }
    }
}
