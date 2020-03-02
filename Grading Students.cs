using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int[] grade = { 73, 67, 38, 33 };
            //int x = 0;
            while (n-- > 0)
            {
                //int g = grade[x++];
                int g = int.Parse(Console.ReadLine());
                if (g < 38)
                {
                    Console.WriteLine(g);
                }
                else
                {
                    int nextMult5 = g;
                    while (nextMult5 % 5 != 0)
                    {
                        nextMult5++;
                    }
                    if (nextMult5 - g < 3)
                    {
                        Console.WriteLine(nextMult5);
                    }
                    else
                    {
                        Console.WriteLine(g);
                    }
                }
            }
        }
    }
}
